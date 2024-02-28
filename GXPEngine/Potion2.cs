using System;
using GXPEngine;

public class Potion2 : Sprite {

    private Note noteP2;

    public Potion2(Note n) : base("two.png")
    {
        noteP2 = n;

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
        }

    }


}

