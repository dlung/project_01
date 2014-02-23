using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

	public float motor_torque;
	public float maxAngularVelocity = 200f;
	public Rigidbody motor_axle;

	// Use this for initialization
	void Start () {
	

		

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		motor_axle.maxAngularVelocity = maxAngularVelocity;
		motor_axle.AddRelativeTorque(-Vector3.up*motor_torque);


	}
}
