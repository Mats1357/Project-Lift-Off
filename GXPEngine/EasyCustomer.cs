using System;
using GXPEngine;


public class EasyCustomer : AnimationSprite {

	MyGame game;
	//RemoveCustomer remove_customer;

	float slideSpeed = 2f;
	float slideSpeedNote;

	public bool P1Done = false;
    public bool P2Done = false;
    public bool P3Done = false;

    bool isDone = false;

	bool orderDone = false;
	
	public EasyCustomer(MyGame g, float sSN) : base("Character_Sprites/sprite_sheet_easy.png", 3, 1)
	{
		game = g;
		slideSpeedNote = sSN;
		SetFrame(2);
	}

	void Update()
	{
		if (!orderDone)
		{
            if (x >= 583)
            {
                if (!isDone)
                {
                    game.EasyCNotes(slideSpeedNote, this);
                    isDone = true;
                }

                if (P1Done && P2Done && P3Done)
                {
                    orderDone = true;

                    SetFrame(1);
                    
                }
            }

            else
            {

                x = x + slideSpeed;


            }
        }

		else
		{
            x = x - slideSpeed;

            if (x <= -463)
            {
				orderDone = false;
                this.Destroy();

				game.win = true;
				game.Win();
            }
        }
		
	}

	/*public void Leave()
	{
		SetFrame(1);

		while(x >= -463)
		{
			x = x - slideSpeed;
		}

		Destroy();
	}*/

}






