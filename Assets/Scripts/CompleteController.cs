﻿using UnityEngine;
using System.Collections;

public class CompletePController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Player Died");
            //col.getCompontent<PlayerDeath>().kill();

        }
    }
}
