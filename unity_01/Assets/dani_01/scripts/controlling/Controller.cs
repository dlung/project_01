using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class Controller : KeyMethods{


	// struct for key boundaries, like key + triggermode + function to call
	public struct keyBindingBoundary
	{
		public KeyCode[] keys;
		public int	triggermode;
		public Action function;

		public keyBindingBoundary(KeyCode[] keys, int triggermode, Action function)
		{

			if(keys.Length <= 3) {
				this.keys = new KeyCode[keys.Length];
				this.keys = keys;
			} else {
				this.keys = new KeyCode[3];
			}


			if(triggermode >= 0 && triggermode <= 2)
				this.triggermode = triggermode;
			else
				this.triggermode = 0;


			if(function == null)
				this.function = () => Brain.doNothing();
			else
				this.function = function;
		}

		public bool containsKey(KeyCode k)
		{
			if(this.keys != null) {
				foreach(KeyCode key in this.keys) {
					if(key != null && this.keys.Length > 0) {
						if(key == k)
							return true;
					}
				}
			}
			return false;
		}

		public bool containsKeyAt(KeyCode k, int i)
		{
			if(this.keys != null) {
				Debug.Log ("this.keys.length = "+this.keys.Length);
				if(this.keys.Length < i)
				{
					if(this.keys[i-1] == k)
						return true;

				}
			}
			return false;
		}
	}


	private static GameObject target;
	private static GameObject player;
	
	private Dictionary<string, keyBindingBoundary> keyBindings;
	
	private bool keyBindingsInitiated = false;
	
	
	
	
	/********************************************************************************************* CONSTRUCTOR & ROUTINES*/
	public Controller()
	{
		Debug.Log ("Controller.CONSTRUCTOR()");
		
		if(keyBindings == null)
			createKeyBindings();
		
		if(!keyBindingsInitiated)
			initKeyBindings();
		
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
	
	private void createKeyBindings()
	{
		keyBindings = new Dictionary<string, keyBindingBoundary>();
	}
	
	
	
	/********************************************************************************************* INITIALIZATION-METHODS */
	
	private void initKeyBindings()
	{
		initKeyBindingsDefault ();

		// finished keyBinding initialization
		keyBindingsInitiated = true;
	}
	
	private void initKeyBindingsDefault()
	{
		string[] actions = new string[9]
		{
			// mouse actions
			"leftClick",
			"rightClick",

			// move actions
			"moveForward",
			"moveBack",
			"moveLeft",
			"moveRight",

			// other & testing actions
			"sayBla",
			"createCar",
			"save"
		};

		foreach(string key in actions)
		{
			keyBindings.Add(key, new keyBindingBoundary());
		}

		keyBindings["moveForward"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.W}, 0, () => moveForward());
		keyBindings["moveBack"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.S}, 0, () => moveBack());
		keyBindings["moveLeft"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.A}, 0, () => moveLeft());
		keyBindings["moveRight"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.D}, 0, () => moveRight());

		keyBindings["jump"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.Space}, 1, () => jump());
		keyBindings["crouch"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.LeftControl}, 1, () => crouch());
		keyBindings["boost"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.LeftShift}, 0, () => boost());

		keyBindings["createCar"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.C}, 1, () => createCar("auto01"));
		keyBindings["sayBla"] = new keyBindingBoundary(new KeyCode[1]{KeyCode.B}, 1, () => sayBla());

		//keyBindings["save"] = new keyBindingBoundary(new KeyCode[2]{KeyCode.LeftShift, KeyCode.S}, 1, () => save());
	}
	
	
	
	/********************************************************************************************* OTHER METHODS */
	
	
	
	public KeyCode[] getKeysPressed()
	{
		KeyCode[] keys = new KeyCode[10];
		int i = 0;
		
		// mouse
		if(Input.GetKey(KeyCode.Mouse0) && i <= 10){ keys[i] = KeyCode.Mouse0; i++; }
		if(Input.GetKey(KeyCode.Mouse1) && i <= 10){ keys[i] = KeyCode.Mouse1; i++; }
		
		// usual moving keys
		if(Input.GetKey(KeyCode.W) && i <= 10){ keys[i] = KeyCode.W; i++; }
		if(Input.GetKey(KeyCode.A) && i <= 10){ keys[i] = KeyCode.A; i++; }
		if(Input.GetKey(KeyCode.S) && i <= 10){ keys[i] = KeyCode.S; i++; }
		if(Input.GetKey(KeyCode.D) && i <= 10){ keys[i] = KeyCode.D; i++; }
		
		// usual second important keys
		if(Input.GetKey(KeyCode.Space) && i <= 10){ keys[i] = KeyCode.Space; i++; }
		if(Input.GetKey(KeyCode.R) && i <= 10){ keys[i] = KeyCode.R; i++; }
		if(Input.GetKey(KeyCode.LeftShift) && i <= 10){ keys[i] = KeyCode.LeftShift; i++; }
		if(Input.GetKey(KeyCode.LeftControl) && i <= 10){ keys[i] = KeyCode.LeftControl; i++; }
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

	// Get keys that are actually pressed vom keys[]
		KeyCode[] keysPressed;
		int keysPressedNum = 0;

		foreach(KeyCode keyPressed in keys)
		{
			if(keyPressed != KeyCode.None)
				keysPressedNum++;
		}

		keysPressed = new KeyCode[keysPressedNum];

		for(int i = 0; i < keysPressedNum; i++)
		{
			keysPressed[i] = keys[i];
		}


	// get Dictionary entries from keyBindings that do actually matter (have use of keysPressed)

		// iterate through all keyBindings
		foreach(KeyCode keyPressed in keysPressed)
		{
			// iterate through all keys pressed
			foreach(string cmd in keyBindings.Keys)
			{
				/*
				Debug.Log ("current cmd: keyBindings["+cmd+"]");

				// found keyBinding for keyPressed - special case SHIFT
				if(keyPressed == KeyCode.LeftShift || keyPressed == KeyCode.RightShift)
				{
					if(keyBindings[cmd].containsKey (keyPressed))
					{
						Debug.Log (keyBindings[cmd].keys.Length);
						KeyCode otherKey = keyBindings[cmd].keys[1];
					}
				}
				*/

				// found keyBinding for keyPressed
				if(keyBindings[cmd].containsKey (keyPressed))
				{
					if(keyBindings[cmd].triggermode == 0) {

						if(Input.GetKey(keyPressed))
							keyBindings[cmd].function();

					} else if(keyBindings[cmd].triggermode == 1) {

						if(Input.GetKeyDown(keyPressed))
							keyBindings[cmd].function();
					}
				}
			}
		}



		/*
		// check all keyBindings
		foreach(string cmd in keyBindings.Keys)
		{
			int keysPressedIndex = 0;

			//check through all keys pressed
			foreach(KeyCode keyPressed in keysPressed)
			{
				keysPressedIndex++;

				// if keyPressed is shift, special case
				if(keyPressed == KeyCode.LeftShift || keyPressed == KeyCode.RightShift)
				{
					int keysPressed2Index = 0;

					// check through all pressed keys again
					foreach(KeyCode keyPressed2 in keysPressed)
					{
						keysPressed2Index++;

						// but this time ignore shift
						if(keyPressed2 != KeyCode.LeftShift || keyPressed2 != KeyCode.RightShift)
						{
							Debug.Log ("cmd: "+cmd);
							// if current keyBinding contains keysPressed, do stuff
							if(keyBindings[cmd].containsKeyAt(keyPressed2, 2))
							{
								keyBindings[cmd].function();
								Debug.Log("kp2i: "+keysPressed2Index);
								Debug.Log("kp[kp2i]: "+keysPressed[keysPressed2Index-1]);
							}
						}
					}
				// if keyPressed is control, special case
				} else if(keyPressed == KeyCode.LeftControl || keyPressed == KeyCode.RightControl) {

					// check through all pressed keys again
					foreach(KeyCode keyPressed2 in keysPressed)
					{
						// but this time ignore shift
						if(keyPressed2 != KeyCode.LeftShift || keyPressed2 != KeyCode.RightShift)
						{
							// if current keyBinding contains keysPressed, do stuff
							if(keyBindings[cmd].containsKey(keyPressed2))
							{
								keyBindings[cmd].function();
							}
						}
					}

				// if keyPressed is control, special case
				} else if(keyPressed == KeyCode.LeftAlt || keyPressed == KeyCode.RightAlt) {
					
					// check through all pressed keys again
					foreach(KeyCode keyPressed2 in keysPressed)
					{
						// but this time ignore shift
						if(keyPressed2 != KeyCode.LeftShift || keyPressed2 != KeyCode.RightShift)
						{
							// if current keyBinding contains keysPressed, do stuff
							if(keyBindings[cmd].containsKey(keyPressed2))
							{
								keyBindings[cmd].function();
							}
						}
					}

				// in normal case (only one key)
				} else {
			
					if(keyBindings[cmd].containsKey(keyPressed))
					{
						keyBindings[cmd].function();
					}
				}
			}
		}
		*/
	}


}

