using UnityEngine;
using System.Collections;

public class Controller {

	private CameraController cameraController;
	private KeyController keyController;


	public Controller()
	{
		Debug.Log ("Controller.Controller()");
		
		setActiveController("camera");
		keyController = new KeyController();
		setKeySetup("test01");
	}

	
	// routine
	public void observe ()
	{
		this.keyController.work();
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


	void setKeySetup(string cmd)
	{
		if(cmd == "test01")
		{
			Debug.Log ("Keysettings: test01");
			keyController.setSetup("test01");
		}
	}
}
