﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour {

    int Health,MoveSpeed;
    GameObject GameControl;

    // Use this for initialization
    void Start () {
        GameControl = GameObject.Find("GameControl");
        MoveSpeed = GameControl.GetComponent<GameControl>().BlockSpeed;
        Health = GameControl.GetComponent<GameControl>().BlockHealth;

        this.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.down * MoveSpeed/2f);
    }
	
	// Update is called once per frame
	void Update () {
        //Vector3 NewPosition = transform.position + (Vector3.up * -MoveSpeed * Time.deltaTime);
        //this.gameObject.GetComponent<Rigidbody2D>().MovePosition(NewPosition);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Bullet")
        {
            Health = Health - col.gameObject.GetComponent<BulletControl>().Damage;
            print(Health);
            if (Health <= 0)
                Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}