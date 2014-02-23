using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Camera camera;

	private string name;
	private int health;
	private int movespeed;
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


	/********************************************************************************************* GETTER & SETTER */




	/********************************************************************************************* MOVING */

	public void moveForward()
	{
		this.transform.Translate(Vector3.forward * Time.deltaTime * 10);
	}

	public void moveBack()
	{
		this.transform.Translate(Vector3.back * Time.deltaTime * 10);
	}

	public void moveLeft()
	{
		this.transform.Translate(Vector3.left * Time.deltaTime * 10);
	}

	public void moveRight()
	{
		this.transform.Translate(Vector3.right * Time.deltaTime * 10);
	}

}