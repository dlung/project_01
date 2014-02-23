using UnityEngine;
using System.Collections;

public class Brain{

	private AbstractFactory abstractFactory;


	// constructor
	public Brain()
	{
		Debug.Log ("Brain().Brain()");

		abstractFactory = new AbstractFactory();
	}
	

	public AbstractFactory getAbstractFactory()
	{
		return this.abstractFactory;
	}

	/********************************************************************************************* OTHER METHODS */
	
	public static void doNothing(){ }

}
