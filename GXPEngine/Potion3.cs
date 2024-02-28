using System;
using GXPEngine;

public class Potion3 : Sprite {

    private Note noteP3;
    MyGame game;

    public Potion3(Note n, MyGame g) : base("three.png")
    {
        noteP3 = n;
        game = g;

    }

    void Update()
    {

        if (Input.GetKeyDown(Key.THREE))
        {
            Console.WriteLine("You pressed 3");

            if (HitTest(noteP3))
            {
                SetColor(0, 0, 255);
                noteP3.Delete();
            }

            else
            {
                game.game_over = true;
            }
        }

    }


}

