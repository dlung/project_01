using UnityEngine;
using System.Collections;

public class Brain{

	private AbstractFactory abstractFactory;

	public Brain() { Start (); }

	// Use this for initialization
	void Start ()
	{
		abstractFactory = new AbstractFactory();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
