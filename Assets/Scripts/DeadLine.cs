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
            GameObject.Find("GameControl").GetComponent<GameControl>().PauseGame();
        }
    }
}
