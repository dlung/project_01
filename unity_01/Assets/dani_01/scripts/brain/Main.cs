using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	
	private Brain brain;

	private Controller controller;
	private bool controllerInitiated = false;

	private GameObject player;
	private bool playerInitiated = false;



	/********************************************************************************************* START & UPDATE */

	// Use this for initialization
	void Start ()
	{
		Debug.Log("Main.START()");

		if(brain == null)
			brain = new Brain();


		if(!playerInitiated) {
			createPlayer();
			initPlayer();
		}


		if(controller == null)
			createController();

		if(!controllerInitiated)
			initController();

	}


	// Update is called once per frame
	void Update ()
	{
		controller.observe();
	}


	/********************************************************************************************* GETTER & SETTER */

	public Brain getBrain() { return this.brain; }
	public GameObject getPlayer() { return this.player; }



	/********************************************************************************************* CREATE-METHODS */

	private void createPlayer()
	{
		Debug.Log("Main.createPlayer()");

		player = new GameObject("Player");
		player = (GameObject) Object.Instantiate(Resources.Load("humanoid/player/player01"), Vector3.zero, new Quaternion());
		player.AddComponent<Player>();
	}


	private void createController()
	{
		Debug.Log("Main.createController()");

		controller = new Controller();
	}



	/********************************************************************************************* INITIALIZATION-METHODS */

	private void initPlayer()
	{
		Debug.Log("Main.initPlayer()");

		player.name = "Hans";
		playerInitiated = true;
	}


	private void initController()
	{
		Debug.Log("Main.initController()");

		controller.setPlayer(6);
	}

}
