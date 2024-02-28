using System;
using GXPEngine;

public class Potion1 : Sprite {

	private Note noteP1;
	MyGame game;

	public Potion1(Note n, MyGame g) : base("one.png")
	{
		noteP1 = n;
		game = g;

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

			else
			{
				game.game_over = true;
            }
		}
       
    }


}


