using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class Controller : Keymethods {


	private static GameObject target;
	private static GameObject player;

	private Dictionary<List<KeyCode>, string> keyBindings;
	private bool keybindingsInitiated = false;



	/********************************************************************************************* CONSTRUCTOR & ROUTINES*/
	public Controller()
	{
		Debug.Log ("Controller.CONSTRUCTOR()");

		if(keyBindings == null)
			createKeybindings();

		if(!keybindingsInitiated)
			initKeybindings();

		if(target == null)
			Controller.target = null;
	}


	public void observe()
	{

		if(Input.anyKey)
		{
			KeyCode[] keyInput = getKeysPressed();
			handleKeyInput(keyInput);
		}

    }



	/********************************************************************************************* GETTER & SETTER */
	public void setPlayer(int id)
	{
		//this.player = player;
	}

	
	public void setTarget(int id)
	{

	}



	/********************************************************************************************* CREATE-METHODS */

	private void createKeybindings()
	{
		keyBindings = new Dictionary<List<KeyCode>, string>();
	}

	

	/********************************************************************************************* INITIALIZATION-METHODS */

	private void initKeybindings()
	{
		// walking
		keyBindings[new List<KeyCode>(){{KeyCode.W}}]					= "moveForward";
		keyBindings[new List<KeyCode>(){{KeyCode.A}}]					= "moveLeft";
		keyBindings[new List<KeyCode>(){{KeyCode.S}}]					= "moveBack";
		keyBindings[new List<KeyCode>(){{KeyCode.D}}]					= "moveRight";

		// temporary & testing bindings
		keyBindings[new List<KeyCode>(){{KeyCode.B}}]					= "sayBla";
		keyBindings[new List<KeyCode>(){{KeyCode.C}}]					= "createCar";


		// finished keybinding initialization
		keybindingsInitiated = true;
	}

	private void initKeybindingsDefault()
	{
	}



	/********************************************************************************************* OTHER METHODS */


	
	public KeyCode[] getKeysPressed()
	{
		KeyCode[] keys = new KeyCode[10];
		int i = 0;

		// usual moving keys
		if(Input.GetKey(KeyCode.W) && i <= 10){ keys[i] = KeyCode.W; i++; }
		if(Input.GetKey(KeyCode.A) && i <= 10){ keys[i] = KeyCode.A; i++; }
		if(Input.GetKey(KeyCode.S) && i <= 10){ keys[i] = KeyCode.S; i++; }
		if(Input.GetKey(KeyCode.D) && i <= 10){ keys[i] = KeyCode.D; i++; }

		// usual second important keys
		if(Input.GetKey(KeyCode.Space) && i <= 10){ keys[i] = KeyCode.Space; i++; }
		if(Input.GetKey(KeyCode.R) && i <= 10){ keys[i] = KeyCode.R; i++; }
		if(Input.GetKey(KeyCode.RightControl) && i <= 10){ keys[i] = KeyCode.LeftControl; i++; }
		if(Input.GetKey(KeyCode.LeftControl) && i <= 10){ keys[i] = KeyCode.LeftShift; i++; }
		if(Input.GetKey(KeyCode.LeftAlt) && i <= 10){ keys[i] = KeyCode.LeftAlt; i++; }
		if(Input.GetKey(KeyCode.Tab) && i <= 10){ keys[i] = KeyCode.Tab; i++; }

		// normal numbers
		if(Input.GetKey(KeyCode.Alpha0) && i <= 10){ keys[i] = KeyCode.Alpha0; i++; }
		if(Input.GetKey(KeyCode.Alpha1) && i <= 10){ keys[i] = KeyCode.Alpha1; i++; }
		if(Input.GetKey(KeyCode.Alpha2) && i <= 10){ keys[i] = KeyCode.Alpha2; i++; }
		if(Input.GetKey(KeyCode.Alpha3) && i <= 10){ keys[i] = KeyCode.Alpha3; i++; }
		if(Input.GetKey(KeyCode.Alpha4) && i <= 10){ keys[i] = KeyCode.Alpha4; i++; }
		if(Input.GetKey(KeyCode.Alpha5) && i <= 10){ keys[i] = KeyCode.Alpha5; i++; }
		if(Input.GetKey(KeyCode.Alpha6) && i <= 10){ keys[i] = KeyCode.Alpha6; i++; }
		if(Input.GetKey(KeyCode.Alpha7) && i <= 10){ keys[i] = KeyCode.Alpha7; i++; }
		if(Input.GetKey(KeyCode.Alpha8) && i <= 10){ keys[i] = KeyCode.Alpha8; i++; }
		if(Input.GetKey(KeyCode.Alpha9) && i <= 10){ keys[i] = KeyCode.Alpha9; i++; }

		// top letter row
		if(Input.GetKey(KeyCode.Q) && i <= 10){ keys[i] = KeyCode.Q; i++; }
		if(Input.GetKey(KeyCode.E) && i <= 10){ keys[i] = KeyCode.E; i++; }
		if(Input.GetKey(KeyCode.T) && i <= 10){ keys[i] = KeyCode.T; i++; }
		if(Input.GetKey(KeyCode.Z) && i <= 10){ keys[i] = KeyCode.Z; i++; }
		if(Input.GetKey(KeyCode.U) && i <= 10){ keys[i] = KeyCode.U; i++; }
		if(Input.GetKey(KeyCode.I) && i <= 10){ keys[i] = KeyCode.I; i++; }
		if(Input.GetKey(KeyCode.O) && i <= 10){ keys[i] = KeyCode.O; i++; }
		if(Input.GetKey(KeyCode.P) && i <= 10){ keys[i] = KeyCode.P; i++; }

		// middle letter row
		if(Input.GetKey(KeyCode.F) && i <= 10){ keys[i] = KeyCode.F; i++; }
		if(Input.GetKey(KeyCode.G) && i <= 10){ keys[i] = KeyCode.G; i++; }
		if(Input.GetKey(KeyCode.H) && i <= 10){ keys[i] = KeyCode.H; i++; }
		if(Input.GetKey(KeyCode.J) && i <= 10){ keys[i] = KeyCode.J; i++; }
		if(Input.GetKey(KeyCode.K) && i <= 10){ keys[i] = KeyCode.K; i++; }
		if(Input.GetKey(KeyCode.L) && i <= 10){ keys[i] = KeyCode.L; i++; }

		// bottom letter row
		if(Input.GetKey(KeyCode.Y) && i <= 10){ keys[i] = KeyCode.Y; i++; }
		if(Input.GetKey(KeyCode.X) && i <= 10){ keys[i] = KeyCode.X; i++; }
		if(Input.GetKey(KeyCode.C) && i <= 10){ keys[i] = KeyCode.C; i++; }
		if(Input.GetKey(KeyCode.V) && i <= 10){ keys[i] = KeyCode.V; i++; }
		if(Input.GetKey(KeyCode.B) && i <= 10){ keys[i] = KeyCode.B; i++; }
		if(Input.GetKey(KeyCode.N) && i <= 10){ keys[i] = KeyCode.N; i++; }
		if(Input.GetKey(KeyCode.M) && i <= 10){ keys[i] = KeyCode.M; i++; }
		if(Input.GetKey(KeyCode.Comma) && i <= 10){ keys[i] = KeyCode.Comma; i++; }
		if(Input.GetKey(KeyCode.Period) && i <= 10){ keys[i] = KeyCode.Period; i++; }
		if(Input.GetKey(KeyCode.Minus) && i <= 10){ keys[i] = KeyCode.Minus; i++; }


		//Debug.Log ("i: "+i);

		return keys;
	}


	private void handleKeyInput(KeyCode[] keys)
	{
		Dictionary<KeyCode, bool> keysFinal;
		keysFinal = new Dictionary<KeyCode, bool>();

		foreach(KeyCode key in keys)
		{
			if(key != KeyCode.None)
			{
				// Dieses foreach suckt hart
				foreach(List<KeyCode>  l in keyBindings.Keys)
				{
					if(l.Contains(key))
					{
						foreach(bool once in (methodlist[keyBindings[l].ToString ()]).Keys)
						{
							//Debug.Log(once);
							keysFinal.Add(key, once);
						}
					}
				}


				foreach(KeyCode keyf in keysFinal.Keys)
				{
					Debug.Log ("Final Keys: "+keyf+" - once: "+keysFinal[keyf]);

					// If once, like map, flashlight, jump, etc.
					if(keysFinal[keyf])
					{
						if(Input.GetKeyDown(keyf))
						{
							// Dieses foreach suckt hart
							foreach(List<KeyCode>  l in keyBindings.Keys)
							{
								if(l.Contains(keyf))
								{
									foreach(Action a in methodlist[keyBindings[l].ToString()].Values)
										a();
								}
							}
						}

					// If !once, like walk, crouch, etc.
					} else {
						if(Input.GetKey(keyf))
						{
							// Dieses foreach suckt hart
							foreach(List<KeyCode>  l in keyBindings.Keys)
							{
								if(l.Contains(keyf))
								{
									foreach(Action a in methodlist[keyBindings[l].ToString()].Values)
										a();
								}
							}
						}
					}

				}
			
			}
		}

	}
	
}


/*

X	1. Checke alle Tasten auf getKey

X	2. mache keys[] mit allen gedrückten Tasten

X	3. hole für alle keys[], falls belegt, ob getKey oder nicht

X	4. mache neus Dictionary<KeyCode, bool> mit den gedrückten keys und ob getKey oder nicht

	5. checke alle keys aus Dictionary<KeyCode, bool> diesmal richtig, mit je getKey oder getKeyDown

	6. Führe entsprechende Funktion aus
	
*/


/*Strange old stuff
 * 

		//foreach(KeyCode kc in keyBindings 

			foreach(Action function in (methodlist[keyBindings[KeyCode.B].ToString ()]).Values)
				function();

			foreach(bool once in (methodlist[keyBindings[KeyCode.B].ToString ()]).Keys)
				Debug.Log(once);

			//Debug.Log(	(methodlist[keyBindings[KeyCode.B].ToString ()])		);

//Debug.Log(l2.GetHashCode());


Dictionary<KeyCode, string> wtf;
				wtf = new Dictionary<KeyCode, string>();
				wtf[KeyCode.C] = "WAZZAAAAAAAAAAAP";



if(keyBindings.ContainsKey(l2))
	//if(wtf.ContainsKey (key))
{
	//Debug.Log (key+" is used <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
}


				foreach(Action function in (methodlist[keyBindings[KeyCode.B].ToString ()]).Values)
					function();
				
				foreach(bool once in (methodlist[keyBindings[KeyCode.B].ToString ()]).Keys)
					Debug.Log(once);

*/










