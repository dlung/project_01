using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour{

	private int mode;

	// keyboard control variables
	private bool forward;
	private bool backward;
	private bool left;
	private bool right;
	private bool down;
	private bool jump;
	private bool sprint;

	// mouse control variables
	private float hor;
	private float ver;


	// Use this for initialization
	void Start ()
	{
		Debug.Log ("CameraController.Start()");

		if(mode == null)
			mode = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log ("CameraController.Update()");

		switch(this.mode)
		{
		default:
		case 0:
			break;
		case 1:
			controlWASD_01();
			break;
		}
	}

	public void setMode(int mode)
	{
		Debug.Log ("Setting mode of "+this.name+" to 1");
		this.mode = mode;
	}


	private void controlWASD_01()
	{
		bool forward = Input.GetKeyDown (KeyCode.W);
		bool backward = Input.GetKeyDown (KeyCode.S);
		bool left = Input.GetKeyDown (KeyCode.A);
		bool right = Input.GetKeyDown (KeyCode.D);
		bool down = Input.GetKeyDown (KeyCode.LeftControl);
		bool up = Input.GetKeyDown (KeyCode.Space);
		bool fast = Input.GetKeyDown (KeyCode.LeftShift);
		
		float hor = Input.GetAxisRaw ("Horizontal");
		float ver = Input.GetAxisRaw ("Vertical");

		float speed = 1f;

		if(forward) {
			Debug.Log ("Move forward");
			camera.transform.Translate(Vector3.forward * speed);
		} else if(backward) {
			Debug.Log ("Move backward");
			camera.transform.Translate(Vector3.back);
		}

		if(left) {
			Debug.Log ("Move left");
			camera.transform.Translate(Vector3.left);
		} else if(right) {
			Debug.Log ("Move right");
			camera.transform.Translate(Vector3.right);
		}

		if(up) {
			Debug.Log ("Move up");
			camera.transform.Translate(Vector3.up);
		} else if(down) {
			Debug.Log ("Move down");
			camera.transform.Translate(Vector3.down);
		}

		if(fast)
			speed = 3f;
		else
			speed = 1f;
	}

}
