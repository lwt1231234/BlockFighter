using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject Bullet;

    GameObject GameControl;

    //游戏局部参数
    int MoveSpeed, BlockWide;


    // Use this for initialization
    void Start () {
        GameControl = GameObject.Find("GameControl");
        MoveSpeed = GameControl.GetComponent<GameControl>().PlayerSpeed;
        BlockWide = GameControl.GetComponent<GameControl>().BlockWide;
    }
	
	// Update is called once per frame
	void Update () {
        MoveSpeed = GameControl.GetComponent<GameControl>().PlayerSpeed;

        if (Input.GetKey (KeyCode.A)||Input.GetKey (KeyCode.LeftArrow)) {
			//transform.Translate (Vector3.right *- MoveSpeed*Time.deltaTime);
			Vector3 NewPosition = transform.position+(Vector3.right *- MoveSpeed*Time.deltaTime);
			this.gameObject.GetComponent<Rigidbody2D> ().MovePosition(NewPosition);
		}
		if (Input.GetKey (KeyCode.D)||Input.GetKey (KeyCode.RightArrow)) {
			Vector3 NewPosition = transform.position+(Vector3.right *+ MoveSpeed*Time.deltaTime);
			this.gameObject.GetComponent<Rigidbody2D> ().MovePosition(NewPosition);
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			Vector3 Position = transform.position + (Vector3.up *+(BlockWide/ 200f +0.2f));
			Instantiate (Bullet, Position, Quaternion.identity);
            //bullet.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.up * MoveSpeed);

        }
	}
}
