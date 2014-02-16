using UnityEngine;
using System.Collections;

public class VehicleFactory : MonoBehaviour {

	private CarFactory carFactory;

	// Use this for initialization
	void Start ()
	{
		carFactory = new CarFactory();
	}
	
	// Update is called once per frame
	void Update ()
	{

	
	}
}
