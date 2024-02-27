using GXPEngine;
using System;

public class NoteP1 : Sprite { 

    float slideSpeed = 2f;

    public String text = "test";

    public NoteP1() : base("note.png")
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