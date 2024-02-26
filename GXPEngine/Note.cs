using GXPEngine;
using System;

public class Note : Sprite { 

    float slideSpeed = 2f;

    public Note() : base("note.png")
    {


    }

    void Update()
    {

        x = x + slideSpeed;

        /*
        if (HitTest(other:)
        {
            if (Input.GetKeyDown(Key.ONE))
            Destroy();
        }
        */
    }


}