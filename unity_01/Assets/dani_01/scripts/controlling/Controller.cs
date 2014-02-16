using UnityEngine;
using System.Collections;

public class Controller{

	private CameraController cameraController;

	public Controller() { Start (); }

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Controller.Start()");
		setActiveController("camera");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void setActiveController(string cmd)
	{
		if(cmd == "camera")
		{
			Debug.Log ("Controls active for: CAMERA");
			Camera.main.gameObject.AddComponent(typeof(CameraController));
			CameraController camController = Camera.main.GetComponent<CameraController>();
			camController.setMode(1);
		}
	}
}
