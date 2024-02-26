using System;
using GXPEngine;

public class Potion1 : Sprite
{
	public Potion1() : base("one.png")
	{
		

	}

	void Update()
	{ 

		if(Input.GetKeyDown(Key.ONE))
		{
			Console.WriteLine("You pressed 1");
			SetColor(255, 0, 0);
		}
       
    }


}


