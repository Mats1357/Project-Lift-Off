using GXPEngine;
using System;

public class Note : Sprite {

    float slideSpeed;

    public String text = "test";

    public Note(float slide_speed) : base("note.png")
    {
        slideSpeed = slide_speed;

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