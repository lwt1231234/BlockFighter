using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject Bullet;
	int MoveSpeed=10;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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
			Vector3 Position = transform.position + (Vector3.up * +0.4f);
			print (Position);
			Instantiate (Bullet, Position, Quaternion.identity);
		}
	}
}
