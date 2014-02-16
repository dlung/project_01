using UnityEngine;
using System.Collections;

public class VehicleFactory {

	private CarFactory carFactory;


	// constructor
	public VehicleFactory ()
	{
		Debug.Log ("VehicleFactory().VehicleFactory()");
		carFactory = new CarFactory();
	}
	

	public void createCar(string carType) { this.carFactory.createCar(carType); }
}
