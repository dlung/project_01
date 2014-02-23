/*
using UnityEngine;
using System.Collections;

public class KeyController {

	private string setupProfile;
	private bool settedUp = false;


	// constructor
	public KeyController()
	{
		Debug.Log ("KeyController().KeyController()");

		if(setupProfile == null)
			setupProfile = "test01";

		if(!settedUp)
			setup();
	}


	// routine
	public void work ()
	{
		//Debug.Log ("doing stuff with keys");
		setup();

	}


	public void setSetup(string setupProfile)
	{
		this.setupProfile = setupProfile;
		setup();
	}


	private void setup()
	{
		switch(this.setupProfile)
		{
		default:
		case("test01"):
			//Debug.Log("setup() test01");

			if(Input.GetKeyDown(KeyCode.C)) { this.createCar("auto01"); }

			break;
		}
	}


	private void aMethod() { Debug.Log ("DELEGATE"); }




/***************************************************************************************************************************************
 * 
 * 	Key Functions
 * 
 * ************************************************************************************************************************************/
/*
	void createCar(string carType)
	{
		Debug.Log("setup() test01");
		GameObject go = GameObject.Find("brain");
		Main other = (Main) go.GetComponent(typeof(Main));
		other.getBrain().getAbstractFactory().createCar("auto01");
	}

}
*/