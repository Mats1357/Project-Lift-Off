using System;
using GXPEngine;

public class Potion3 : Sprite
{
    public Potion3() : base("three.png")
    {


    }

    void Update()
    {

        if (Input.GetKeyDown(Key.THREE))
        {
            Console.WriteLine("You pressed 3");
        }

    }


}

