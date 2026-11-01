using System;
using System.Numerics;

namespace MohawkGame2D;

public class PlayerCar
{
    float playerY;
    
    public void Setup(int playerY)
    {
        this.playerY = playerY;
    }

    public void Update() 
    {
       //Car Movement, Speed and Looping
        float inputY = 0;
        if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
        {
            inputY -= 1;
        }
        playerY += inputY * 200 * Time.DeltaTime;
        if (playerY < -80)
        {
            playerY = 800;
        }

        //Car body, front and rear windows, and headlights
        Draw.SetFillColor(128, 0, 0);
        Draw.Rectangle(280, playerY, 40, 80);
        Draw.SetFillColor(0);
        Draw.Rectangle(280, playerY + 20, 40, 10);
        Draw.Rectangle(280, playerY + 55, 40, 10);
        Draw.FillColor = Color.Yellow;
        Draw.Rectangle(280, playerY, 10, 10);
        Draw.Rectangle(310, playerY, 10, 10);
    }
}
