using UnityEngine;
using System.Collections;

public class AbstractFactory {

	private VehicleFactory vehicleFactory;


	public AbstractFactory()
	{
		Debug.Log ("AbstractFactory().AbstractFactory()");
		vehicleFactory = new VehicleFactory();
	}


	public void createCar(string carType) { this.vehicleFactory.createCar(carType); }
}
