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
        //Background cars
        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();
        Car car4 = new Car();
        Car car5 = new Car();
        Car car6 = new Car();

        //Player car
        PlayerCar player = new PlayerCar();

        //Trees
        Trees tree1 = new Trees();
        Trees tree2 = new Trees();
        Trees tree3 = new Trees();
        Trees tree4 = new Trees();
        Trees tree5 = new Trees();
        Trees tree6 = new Trees();
        Trees tree7 = new Trees();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //Game Window
            Window.SetTitle("Cars");
            Window.SetSize(600, 800);

            //NPC Cars
            car1.Setup(100, 215, 450);
            car2.Setup(450, 615, 200);
            car3.Setup(0, 615, 200);
            car4.Setup(650, 160, -350);
            car5.Setup(200, 560, -200);
            car6.Setup(200, 160, -350);

            //Player Car
            player.Setup(740);

            //Trees
            tree1.Setup(100, 200);
            tree2.Setup(200, 300);
            tree3.Setup(70, 400);
            tree4.Setup(390, 400);
            tree5.Setup(480, 350);
            tree6.Setup(530, 300);
            tree7.Setup(380, 280);

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

            //NPC cars
            car1.Update();
            car2.Update();
            car3.Update();
            car4.Update();
            car5.Update();
            car6.Update();

            //Player car
            player.Update();
            
            //Trees
            tree1.Update();
            tree2.Update();
            tree3.Update();
            tree4.Update();
            tree5.Update();
            tree6.Update();
            tree7.Update();





        }
    }

}
