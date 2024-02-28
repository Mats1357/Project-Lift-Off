using System;                                   // System contains a lot of default C# libraries 
using GXPEngine;                                // GXPEngine contains the engine
using System.Drawing;                           // System.Drawing contains drawing tools such as Color definitions

public class MyGame : Game {

	GameOver gameOver;
	public bool game_over = false;

    public MyGame() : base(1366, 768, false)     // Create a window that's 1366x768 and NOT fullscreen
	{
		EasyCustomer easy_customer = new EasyCustomer();
        Note noteP1 = new Note(2);
		Note noteP2 = new Note(1);
		Note noteP3 = new Note(2);
        Potion1 potion1 = new Potion1(noteP1, this);
		Potion2 potion2 = new Potion2(noteP2);
		Potion3 potion3 = new Potion3(noteP3);


         gameOver = new GameOver();

        AddChild(easy_customer);
		AddChild(potion1);
        AddChild(potion2);
        AddChild(potion3);
		AddChild(noteP1);
		AddChild(noteP2);
		AddChild(noteP3);

        easy_customer.SetXY(-200, 150);
		potion1.SetXY(200, 400);
        potion2.SetXY(300, 400);
        potion3.SetXY(400, 400);
		noteP1.SetXY(-50, 475);
		noteP2.SetXY(-50, 525);
		noteP3.SetXY(-150, 575);

        Console.WriteLine("MyGame initialized");
	}

	// For every game object, Update is called every frame, by the engine:
	void Update() {

		StopGame();
		
	}

	public void StopGame()
	{
		if (game_over == true)
		{
            AddChild(gameOver);

            if (Input.GetKeyDown(Key.FOUR))
            {
                Console.WriteLine("You want to quit the game!");
                Destroy();

            }

            
        }
		
		
	}

    static void Main()                          // Main() is the first method that's called when the program is run
    {
        new MyGame().Start();                   // Create a "MyGame" and start it
    }
}