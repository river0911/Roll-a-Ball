﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10;
	
	// Update is called once per frame
	void FixedUpdate () {

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Rigidbody rigidBody = GetComponent<Rigidbody>();
		rigidBody.AddForce (x * speed, 0, z * speed);
	}
}
