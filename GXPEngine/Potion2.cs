using System;
using GXPEngine;

public class Potion2 : Sprite
{

    private Note noteP2;
    MyGame game;
    EasyCustomer easyCustomer;
    //RemoveCustomer remove_customer;

    Sound sound = new Sound("sounds/Mushroom.mp3", false, false);

    public Potion2(Note n, MyGame g, EasyCustomer ec) : base("note_border.png")
    {
        noteP2 = n;
        game = g;
        easyCustomer = ec;
    }

    void Update()
    {

        if (Input.GetKeyDown(Key.TWO))
        {
            Console.WriteLine("You pressed 2");

            if (HitTest(noteP2))
            {
                sound.Play();
                noteP2.Delete();
                easyCustomer.P2Done = true;
            }

            else
            {
                game.game_over = true;
            }
        }

    }


}


