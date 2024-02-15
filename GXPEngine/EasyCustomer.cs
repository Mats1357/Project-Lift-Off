using System;
using GXPEngine;


public class EasyCustomer : Sprite {

	float slideSpeed = 2f;
	
	public EasyCustomer() : base("customer.png")
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






