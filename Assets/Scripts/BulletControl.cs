﻿using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {
    public bool NotPaused;

    public int Damage;

    int MoveSpeed;
    GameObject GameControl;

    // Use this for initialization
    void Start () {
        NotPaused = true;
        GameControl = GameObject.Find("GameControl");
        MoveSpeed = GameControl.GetComponent<GameControl>().BulletSpeed;
        Damage = GameControl.GetComponent<GameControl>().BulletDamage;

        //this.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.up * MoveSpeed);
    }
	
	// Update is called once per frame
	void Update () {
        if (NotPaused)
        {
            Vector3 NewPosition = transform.position + (Vector3.up * +MoveSpeed * Time.deltaTime);
            this.gameObject.GetComponent<Rigidbody2D>().MovePosition(NewPosition);
        }      
	}
}
