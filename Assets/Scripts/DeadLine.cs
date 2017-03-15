using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Block")
        {
            GameObject[] target_Blocks = GameObject.FindGameObjectsWithTag("Block");
            foreach (GameObject Block in target_Blocks)
                Block.GetComponent<BlockControl>().NotPaused = false;
            GameObject[] target_Bullets = GameObject.FindGameObjectsWithTag("Bullet");
            foreach (GameObject Bullet in target_Bullets)
            {
                Bullet.GetComponent<BulletControl>().NotPaused = false;
                //print(Bullet.GetComponent<BulletControl>().NotPaused);
            }
            GameObject.Find("GameControl").GetComponent<GameControl>().NotPaused = false;
        }
    }
}
