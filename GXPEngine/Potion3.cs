using System;
using GXPEngine;

public class Potion3 : Sprite
{

    private Note noteP3;
    MyGame game;
    EasyCustomer easyCustomer;
    //RemoveCustomer remove_customer;

    Sound sound = new Sound("sounds/Flower_herb.mp3", false, false);

    public Potion3(Note n, MyGame g, EasyCustomer ec) : base("note_border.png")
    {
        noteP3 = n;
        game = g;
        easyCustomer = ec;
    }

    void Update()
    {

        if (Input.GetKeyDown(Key.THREE))
        {
            Console.WriteLine("You pressed 3");

            if (HitTest(noteP3))
            {
                sound.Play();
                noteP3.Delete();
                easyCustomer.P3Done = true;
            }

            else
            {
                game.game_over = true;
            }
        }

    }


}


