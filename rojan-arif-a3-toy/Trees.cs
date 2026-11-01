using System;
using System.Numerics;

namespace MohawkGame2D;

public class Trees
{
    float treeX;
    float treeY;
    public void Setup(int treeX, int treeY)
    {
        this.treeX = treeX;
        this.treeY = treeY;
    }
    public void Update()
    {
        Draw.SetFillColor(62, 134, 103);
        Draw.Triangle(treeX, treeY, treeX-20, treeY+40, treeX+20, treeY+40);
        Draw.Triangle(treeX, treeY+10, treeX-20, treeY+60, treeX+20, treeY+60);
        Draw.Triangle(treeX, treeY+20, treeX-20, treeY+80, treeX+20, treeY+80);
        Draw.SetFillColor(75, 40, 30);
        Draw.Square(treeX - 10, treeY + 80, 20);
    }
}
