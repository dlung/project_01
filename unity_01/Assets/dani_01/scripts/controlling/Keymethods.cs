using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class Keymethods {


	protected Dictionary<bool, Action> methodinfo;
	protected Dictionary<string, Dictionary<bool, Action>>methodlist;
	private bool methodlistInitialized;

	private GameObject brain;
	private Main main;
	private GameObject player;



	/********************************************************************************************* CONSTRUCTOR & ROUTINES*/

	public Keymethods()
	{
		this.brain = GameObject.Find("brain");
		this.main = (Main) brain.GetComponent(typeof(Main));
		this.player = main.getPlayer();


		if(methodlist == null) {
			methodinfo = new Dictionary<bool, Action>();
			methodlist = new Dictionary<string, Dictionary<bool, Action>>();
		}


		if(!methodlistInitialized)
			initMethodlist();
	}



	/********************************************************************************************* GETTER & SETTER */



	/********************************************************************************************* INITIALIZATION-METHODS */
	
	private void initMethodlist()
	{
		methodlist["moveForward"] = new Dictionary<bool, Action>{ {false, () => moveForward()} };
		methodlist["moveBack"] = new Dictionary<bool, Action>{ {false, () => moveBack()} };
		methodlist["moveLeft"] = new Dictionary<bool, Action>{ {false, () => moveLeft()} };
		methodlist["moveRight"] = new Dictionary<bool, Action>{ {false, () => moveRight()} };
		methodlist["crouch"] = new Dictionary<bool, Action>{ {false, () => crouch()} };
		methodlist["jump"] = new Dictionary<bool, Action>{ {false, () => jump()} };

		methodlist["sayBla"] = new Dictionary<bool, Action>{ {false, () => sayBla ()}  };
		methodlist["createCar"] = new Dictionary<bool, Action>{ {true, () => createCar ()}  };
	}



	/********************************************************************************************* CREATE / OTHER METHODS */

	public void createCar(){
		main.getBrain().getAbstractFactory().createCar("auto01");
	}

	// player moving methods
	public void moveForward(){ this.player.GetComponent<Player>().moveForward(); }
	public void moveBack(){ this.player.GetComponent<Player>().moveBack(); }
	public void moveLeft(){ this.player.GetComponent<Player>().moveLeft(); }
	public void moveRight(){ this.player.GetComponent<Player>().moveRight(); }
	public void jump() { }
	public void crouch() { }

	private void sayBla()
	{
		Debug.Log ("BLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
	}
	
}