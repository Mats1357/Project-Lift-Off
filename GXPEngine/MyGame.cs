using System;                                   // System contains a lot of default C# libraries 
using GXPEngine;                                // GXPEngine contains the engine
using System.Drawing;                           // System.Drawing contains drawing tools such as Color definitions

public class MyGame : Game {

	GameOver gameOver;
    WinScreen winScreen;
	public bool game_over = false;
    public bool win = false;
 




    public MyGame() : base(1366, 768, false)     // Create a window that's 1366x768 and NOT fullscreen
	{
        EasyCustomer easy_customer = new EasyCustomer(this, 1);

        //RemoveCustomer remove_customer = new RemoveCustomer(easy_customer);

        
     
        //remove_customer.currentCustomer = 1;
        easy_customer.SetXY(-463, 150);

        Sprite background = new Sprite("bg without desk.png");
		Sprite desk = new Sprite("desk with things_correct size.png");
        
        AnimationSprite main_character = new AnimationSprite("Character_Sprites/sprite_sheet_witch.png", 16, 1);
        main_character.SetFrame(4);

		Sound music = new Sound("sounds/game_demo_6.mp3", true, true);
		music.Play();

         gameOver = new GameOver();
        winScreen = new WinScreen();
        

		AddChild(background);
        AddChild(easy_customer);
		AddChild(desk);
        AddChild(main_character);

        main_character.SetXY(800, 200);
		
		
       
		
		
        Console.WriteLine("MyGame initialized");
	}

	// For every game object, Update is called every frame, by the engine:
	void Update() {

		StopGame();
		
	}

    /*public void SpawnCustomer()
    {
        //Random rand = new Random();

        int newCustomerType = 1;//rand.Next(1, 4);

        switch (newCustomerType)
        {
            case 1:
                
                break;
            case 2:
                //medium_customer.Leave();
                break;
            case 3:
                //hard_customer.Leave();
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }*/

	public void EasyCNotes(float sSpeed, EasyCustomer ec)
	{
		float slideSpeedNote;
        EasyCustomer easyCustomer;

		slideSpeedNote = sSpeed;
        easyCustomer = ec;

        Note noteP1 = new Note(slideSpeedNote);
        Note noteP2 = new Note(slideSpeedNote);
        Note noteP3 = new Note(slideSpeedNote);

        AddChild(noteP1);
        AddChild(noteP2);
        AddChild(noteP3);

        noteP1.SetXY(-50, 475);
        noteP2.SetXY(-250, 525);
        noteP3.SetXY(-150, 575);

        Potion1 potion1 = new Potion1(noteP1, this, easyCustomer);
        Potion2 potion2 = new Potion2(noteP2, this, easyCustomer);
        Potion3 potion3 = new Potion3(noteP3, this, easyCustomer);

        AddChild(potion1);
        AddChild(potion2);
        AddChild(potion3);

        potion1.SetXY(540, 400);
        potion2.SetXY(610, 400);
        potion3.SetXY(680, 400);

    }

    

    public void StopGame()
	{
		if (game_over == true)
		{
            AddChild(gameOver);

            if (Input.GetKeyDown(Key.ENTER))
            {
                Console.WriteLine("You want to quit the game!");
                Destroy();

            } 
        }
	}

    public void Win()
    {
        if (win == true)
        {
            AddChild(winScreen);

            if (Input.GetKeyDown(Key.FIVE))
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