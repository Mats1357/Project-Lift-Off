using System;
using GXPEngine;

public class Potion2 : Sprite {

    private NoteP2 noteP2;

    public Potion2(NoteP2 n) : base("two.png")
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

