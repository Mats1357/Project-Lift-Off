using System;
using GXPEngine;

public class Potion3 : Sprite
{

    private Note noteP3;

    public Potion3(Note n) : base("three.png")
    {
        noteP3 = n;

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
        }

    }


}

