using System;
using GXPEngine;

public class Potion1 : Sprite {

	private Note noteP1;

	public Potion1(Note n) : base("one.png")
	{
		noteP1 = n;

	}

	void Update()
	{ 

		if(Input.GetKeyDown(Key.ONE))
		{
			Console.WriteLine("You pressed 1");


			if (HitTest(noteP1))
			{
				SetColor(255, 0, 0);
				noteP1.Delete();
			}
		}
       
    }


}


