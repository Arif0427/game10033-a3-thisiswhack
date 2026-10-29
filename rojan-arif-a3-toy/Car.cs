using System;
using System.Numerics;

namespace MohawkGame2D;

public class Car
{
    float x;
    float y;
    Color carColor;

    public void Setup(int x, int y)
    {
        this.x = x;
        this.y = y;
        carColor = Random.Color();
    }

    public void Update()
    {
        Draw.FillColor = carColor;
        Draw.Rectangle(x, y, 20, 20);
        Draw.Rectangle(x + 20, y - 20, 40, 40);
        Draw.Rectangle(x + 60, y, 20, 20);
        Draw.SetFillColor(0);
        Draw.Rectangle(x + 30, y - 10, 10, 10);
        Draw.Rectangle(x + 50, y - 10, 10, 10);
        Draw.Circle(x + 20, y + 20, 10);
        Draw.Circle(x + 60, y + 20, 10);
        Draw.SetFillColor(255, 255, 0);
        Draw.Rectangle(x + 70, y, 10, 10);
    }
}
