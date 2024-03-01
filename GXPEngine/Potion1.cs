using System;
using GXPEngine;

public class Potion1 : Sprite {

	private Note noteP1;
	MyGame game;
	EasyCustomer easyCustomer;
	//RemoveCustomer remove_customer;

	Sound sound = new Sound("sounds/Leaves.mp3", false, false);

	public Potion1(Note n, MyGame g, EasyCustomer ec) : base("note_border.png")
	{
		noteP1 = n;
		game = g;
		easyCustomer = ec;
	}

	void Update()
	{ 

		if(Input.GetKeyDown(Key.ONE))
		{
			Console.WriteLine("You pressed 1");

			if (HitTest(noteP1))
			{
				sound.Play();
				noteP1.Delete();
				easyCustomer.P1Done = true;

			}

			else
			{
				game.game_over = true;
            }
		}
       
    }


}


