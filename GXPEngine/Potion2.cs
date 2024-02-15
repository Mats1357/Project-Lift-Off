using System;
using GXPEngine;

public class Potion2 : Sprite
{
    public Potion2() : base("two.png")
    {


    }

    void Update()
    {

        if (Input.GetKeyDown(Key.TWO))
        {
            Console.WriteLine("You pressed 2");
        }

    }


}

