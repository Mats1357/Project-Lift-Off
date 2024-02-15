using System;                                   // System contains a lot of default C# libraries 
using GXPEngine;                                // GXPEngine contains the engine
using System.Drawing;                           // System.Drawing contains drawing tools such as Color definitions

public class MyGame : Game {

	public MyGame() : base(1366, 768, false)     // Create a window that's 1366x768 and NOT fullscreen
	{
		EasyCustomer easy_customer = new EasyCustomer();
		Potion1 potion1 = new Potion1();
		Potion2 potion2 = new Potion2();
		Potion3 potion3 = new Potion3();


		AddChild(easy_customer);
		AddChild(potion1);
        AddChild(potion2);
        AddChild(potion3);

        easy_customer.SetXY(-200, (height / 2) - 100);
		potion1.SetXY(100, 650);
        potion2.SetXY(200, 650);
        potion3.SetXY(300, 650);

        Console.WriteLine("MyGame initialized");
	}

	// For every game object, Update is called every frame, by the engine:
	void Update() {
		
	}

	static void Main()                          // Main() is the first method that's called when the program is run
	{
		new MyGame().Start();                   // Create a "MyGame" and start it
	}
}