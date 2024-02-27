using GXPEngine;
using System;

public class NoteP2 : Sprite
{

    float slideSpeed = 1f;

    public String text = "test";

    public NoteP2() : base("note.png")
    {


    }

    void Update()
    {

        x = x + slideSpeed;

    }

    public void Delete()
    {
        Destroy();
    }

}