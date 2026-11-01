using System;
using System.Numerics;

namespace MohawkGame2D;

public class PlayerCar
{
    //float playerX;
    float playerY;
    
    public void Setup()
    { 
    
    }

    public void Update() 
    {
        playerY = Input.GetMouseY();
        Draw.FillColor = Color.Red;
        Draw.Rectangle(280, playerY - 40, 40, 80);
        Draw.FillColor = Color.Yellow;
        Draw.Rectangle(280, playerY - 40, 10, 10);
        Draw.Rectangle(310, playerY - 40, 10, 10);
    }
}
