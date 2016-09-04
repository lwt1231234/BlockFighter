using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {
	int MoveSpeed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 NewPosition = transform.position+(Vector3.up *+ MoveSpeed*Time.deltaTime);
		this.gameObject.GetComponent<Rigidbody2D> ().MovePosition(NewPosition);
	}
}
