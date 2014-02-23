using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class KeyMethods {


	private GameObject brain;
	private Main main;
	private GameObject player;



	/********************************************************************************************* CONSTRUCTOR & ROUTINES*/

	public KeyMethods()
	{
		this.brain = GameObject.Find("brain");
		this.main = (Main) brain.GetComponent(typeof(Main));
		this.player = main.getPlayer();
	}



	/********************************************************************************************* GETTER & SETTER */



	/********************************************************************************************* INITIALIZATION-METHODS */



	/********************************************************************************************* CREATE / OTHER METHODS */

	public void createCar(string carType){
		main.getBrain().getAbstractFactory().createCar(carType);
	}

	// player mouse methods
	public void leftClick() { /*Debug.Log ("LEFT CLICK <<<<<<<<");*/ }
	public void rightClick() { /*Debug.Log (">>>>>>> RIGHT CLICK");*/ }

	// player moving methods
	public void moveForward(){ this.player.GetComponent<Player>().moveForward(); }
	public void moveBack(){ this.player.GetComponent<Player>().moveBack(); }
	public void moveLeft(){ this.player.GetComponent<Player>().moveLeft(); }
	public void moveRight(){ this.player.GetComponent<Player>().moveRight(); }

	public void boost() { this.player.GetComponent<Player>().boost();  }
	public void jump() { this.player.GetComponent<Player>().jump(); }
	public void crouch() { this.player.GetComponent<Player>().crouch(); }

	protected void sayBla() { Debug.Log ("BLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"); }

	protected void save() { Debug.Log ("SAAAAVE"); }
	
}