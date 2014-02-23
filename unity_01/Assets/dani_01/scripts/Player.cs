using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	private Camera camera;

	private string name;
	private int health;

	public int moveSpeed = 10;
	public int boostSpeed = 30;
	public int jumpHeight = 10;

	private bool boost = false;
	private int situation = 0;
		/* 0 = dead
		 * 1 = alive walking
		 * 2 = car
		 * 3 = boat
		 * 4 = flying vehicle 
		 * */

	/********************************************************************************************* START & UPDATE */

	public void Start()
	{
		this.camera = Camera.main;

		this.camera.transform.parent = this.transform;
	}

	public void Update()
	{

	}


	/********************************************************************************************* GETTER & SETTER */




	/********************************************************************************************* MOVING */

	public void moveForward()
	{
		this.transform.Translate(Vector3.forward * Time.deltaTime * this.moveSpeed);
	}

	public void moveBack()
	{
		this.transform.Translate(Vector3.back * Time.deltaTime * this.moveSpeed);
	}

	public void moveLeft()
	{
		this.transform.Translate(Vector3.left * Time.deltaTime * this.moveSpeed);
	}

	public void moveRight()
	{
		this.transform.Translate(Vector3.right * Time.deltaTime * this.moveSpeed);
	}

	public void jump()
	{
		Debug.Log ("JUMP");

		this.rigidbody.AddForce(Vector3.up * Time.deltaTime * 4000 * jumpHeight);
	}

	public void boost()
	{
		Debug.Log ("BOOST");

		this.boost = true;
	}

	public void crouch()
	{
		Debug.Log ("CROUCH");
	}



}