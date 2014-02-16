using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	private Brain brain;
	private Controller controller;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Main.Start()");
		brain = new Brain();
		controller = new Controller();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
