using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject Bullet;

    GameObject GameControl;

    //游戏局部参数
    int MoveSpeed, BlockWide;
    float ShootInterval;

    bool BulletReady;


    // Use this for initialization
    void Start () {
        GameControl = GameObject.Find("GameControl");
        MoveSpeed = GameControl.GetComponent<GameControl>().PlayerSpeed;
        BlockWide = GameControl.GetComponent<GameControl>().BlockWide;
        ShootInterval = GameControl.GetComponent<GameControl>().ShootInterval;

        BulletReady = true;

        //debug

    }
	
	// Update is called once per frame
	void Update () {
        if(GameControl.GetComponent<GameControl>().NotPaused)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                //transform.Translate (Vector3.right *- MoveSpeed*Time.deltaTime);
                Vector3 NewPosition = transform.position + (Vector3.right * -MoveSpeed * Time.deltaTime);
                this.gameObject.GetComponent<Rigidbody2D>().MovePosition(NewPosition);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 NewPosition = transform.position + (Vector3.right * +MoveSpeed * Time.deltaTime);
                this.gameObject.GetComponent<Rigidbody2D>().MovePosition(NewPosition);
            }
            if (Input.GetKey(KeyCode.J))
            {
                if (BulletReady)
                {
                    Vector3 Position = transform.position + (Vector3.up * +(BlockWide / 200f + 0.2f));
                    Instantiate(Bullet, Position, Quaternion.identity);

                    BulletReady = false;
                    Invoke("ShootRefresh", ShootInterval);
                }

            }
        }
	}

    void ShootRefresh()
    {
        BulletReady = true;
    }
}
