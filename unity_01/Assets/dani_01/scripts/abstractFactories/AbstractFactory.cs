using UnityEngine;
using System.Collections;

public class AbstractFactory {

	private VehicleFactory vehicleFactory;

	// Use this for initialization
	void Start ()
	{
		vehicleFactory = new VehicleFactory();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
