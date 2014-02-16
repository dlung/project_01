using UnityEngine;
using System.Collections;

public class CarFactory {


	// constructor
	public CarFactory ()
	{
		Debug.Log ("CarFactory().CarFactory()");
	}


	public void createCar(string carType)
	{
		switch(carType)
		{
		default:
		case("auto01"):
			createCarTest(1);
			break;
		}

	}


	private void createCarTest(int type)
	{
		if(type == 1)
		{
			Debug.Log("Creating car");
			GameObject car;
			car = (GameObject) Object.Instantiate(Resources.Load("vehicles/complete/Car"), Vector3.zero, new Quaternion());
			car.AddComponent<Car>();
			
			GameObject wheel01;
			wheel01 = (GameObject) Object.Instantiate(Resources.Load("vehicles/parts/wheel01"), Vector3.zero, new Quaternion());
			wheel01.transform.parent = car.transform;

			GameObject wheel02;
			wheel02 = (GameObject) Object.Instantiate(Resources.Load("vehicles/parts/wheel01"), Vector3.zero, new Quaternion());
			wheel02.transform.parent = car.transform;

		}
	}

}
