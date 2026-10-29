// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Cars");
            Window.SetSize(600, 800);

            car1.Setup(100, 215, 150);
            car2.Setup(400, 615, 200);
            car3.Setup(1, 615, 200);


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
           //Grass
            Window.ClearBackground(70, 110, 55);

            //Roads
            Draw.SetLineSize(0);
            Draw.SetFillColor(125);
            Draw.Rectangle(270, 0, 60, 800);
            for (int i = 0; i < 2; i++)
            {
                //int roadx;
                int roady = i * 400 + 150;
                Draw.SetLineSize(0);
                Draw.SetFillColor(125);
                Draw.Rectangle(0, roady, 600, 100);
                
                for (int j = 0; j < 30; j++)
                {
                    int roadx = j * 40;
                    Draw.SetFillColor(239, 183, 0);
                    Draw.Rectangle(roadx + 10, roady + 48, 20, 4);
                }

            }

            car1.Update();
            car2.Update();
            car3.Update();

            //Player car





        }
    }

}
