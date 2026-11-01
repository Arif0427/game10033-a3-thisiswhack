using System;
using System.Numerics;

namespace MohawkGame2D;

public class Car
{
    float x;
    float y;
    //float deltaTime = Time.DeltaTime;
    float speed;
    Color carColor;

    public void Setup(int x, int y, int speed)
    {
        this.x = x;
        this.y = y;
        this.speed = speed;
        carColor = Random.Color();
    }

    public void Update()
    {
        //Car Speed and loopinh
        x += Time.DeltaTime * speed;
        if (speed > 0 && x >= Window.Width)
        {
            x = -80;
        }
        if (speed < 0 && x <= -80)
        {
            x = 600;
        }

        //Car Body
        Draw.FillColor = carColor;
        Draw.Rectangle(x, y, 20, 20);
        Draw.Rectangle(x + 20, y - 20, 40, 40);
        Draw.Rectangle(x + 60, y, 20, 20);
        //Car Windows
        Draw.SetFillColor(0);
        if (speed < 0)
        {
            Draw.Rectangle(x + 20, y - 10, 10, 10);
            Draw.Rectangle(x + 40, y - 10, 10, 10);

        }
        else
        {
            Draw.Rectangle(x + 30, y - 10, 10, 10);
            Draw.Rectangle(x + 50, y - 10, 10, 10);
        }
        //Wheels
        Draw.Circle(x + 20, y + 20, 10);
        Draw.Circle(x + 60, y + 20, 10);
        //Headlights
        Draw.SetFillColor(255, 255, 0);
        if (speed < 0)
        {
            Draw.Rectangle(x, y, 10, 10);
        }
        else
        {
            Draw.Rectangle(x + 70, y, 10, 10);
        }
    }
}
