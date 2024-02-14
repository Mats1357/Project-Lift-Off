using System;
using GXPEngine;


public class Customer : Sprite {

	float slideSpeed = 2f;
	
	public Customer() : base("customer.png")
	{

	}

	void Update()
	{

		if (x >= 583)
		{

		}

		else
		{
            x = x + slideSpeed;
        }
	}

}






