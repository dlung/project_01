﻿using UnityEngine;
using System.Collections;

public class motor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {

		rigidbody.AddTorque(0 ,0 , 1000);


	}
}
