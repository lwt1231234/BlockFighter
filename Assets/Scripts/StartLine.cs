using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour {

    GameObject GameControl;

    // Use this for initialization
    void Start () {
        GameControl = GameObject.Find("GameControl");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.transform.tag == "Block")
            GameControl.GetComponent<GameControl>().CreatNewLine();
    }
}
