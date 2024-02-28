using System;
using GXPEngine;

public class Potion2 : Sprite {

    private Note noteP2;
    MyGame game;

    public Potion2(Note n, MyGame g) : base("two.png")
    {
        noteP2 = n;
        game = g;

    }

    void Update()
    {

        if (Input.GetKeyDown(Key.TWO))
        {
            Console.WriteLine("You pressed 2");

            if (HitTest(noteP2))
            {
                SetColor(0, 255, 0);
                noteP2.Delete();
            }

            else
            {
                game.game_over = true;
            }
        }

    }


}

