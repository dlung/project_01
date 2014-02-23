/*using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour{

	private int mode;

	// keyboard control variables
	private bool forward;
	private bool backward;
	private bool left;
	private bool right;
	private bool down;
	private bool rotateLeft;
	private bool rotateRight;
	private bool jump;
	private bool sprint;

	// mouse control variables
	private float hor;
	private float ver;

	// other variables
	private float speedTranslate = 0.1f;
	private float speedRotate = 3f;
	private float speedMouse = 1.3f;



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
		bool rotatable = false;
		int mouseRotateMode = 1;

		// key control starts here

		bool forward = Input.GetKey (KeyCode.W);
		bool backward = Input.GetKey (KeyCode.S);
		bool left = Input.GetKey (KeyCode.A);
		bool right = Input.GetKey (KeyCode.D);
		bool rotateLeft = Input.GetKey (KeyCode.Q);
		bool rotateRight = Input.GetKey (KeyCode.E);
		bool down = Input.GetKey (KeyCode.LeftControl);
		bool up = Input.GetKey (KeyCode.Space);
		bool fast = Input.GetKey (KeyCode.LeftShift);
		
		float sprint;

		if(fast)
			sprint = 3f;
		else
			sprint = 1f;

		if(forward) {
			//Debug.Log ("Move forward");
			camera.transform.Translate(Vector3.forward * speedTranslate * sprint);
		} else if(backward) {
			//Debug.Log ("Move backward");
			camera.transform.Translate(Vector3.back * speedTranslate * sprint);
		}

		if(left) {
			//Debug.Log ("Move left");
			camera.transform.Translate(Vector3.left * speedTranslate);
		} else if(right) {
			//Debug.Log ("Move right");
			camera.transform.Translate(Vector3.right * speedTranslate);
		}

		if(rotatable)
		{
			if(rotateLeft) {
				//Debug.Log ("Rotate left");
				camera.transform.Rotate(Vector3.forward * speedRotate);
			} else if(rotateRight) {
				//Debug.Log ("Rotate right");
				camera.transform.Rotate(Vector3.back * speedRotate);
			}
		}

		if(up) {
			//Debug.Log ("Move up");
			camera.transform.Translate(Vector3.up * speedTranslate);
		} else if(down) {
			//Debug.Log ("Move down");
			camera.transform.Translate(Vector3.down * speedTranslate);
		}


		// mouse control starts here

		float hor = Input.GetAxisRaw ("Mouse X");
		float ver = Input.GetAxisRaw ("Mouse Y");

		if((hor != 0f || ver != 0f) && Input.GetMouseButton(1))
		{


			switch(mouseRotateMode)
			{
			default:
			case 1:
				camera.transform.RotateAround (camera.transform.position, Vector3.up, hor * speedMouse);
				camera.transform.Rotate(Vector3.left * ver * speedMouse);
				break;
			case 2:
				camera.transform.Rotate(Vector3.up * hor * speedMouse);
				camera.transform.Rotate(Vector3.left * ver * speedMouse);
				break;
			}
		}

	}

}
*/