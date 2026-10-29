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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("This Is Whack");
            Window.SetSize(600, 800);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Draw background and grid
            Window.ClearBackground(70, 110, 55);
            
           
            for (int i = 0; i < 4; i++)
            {
                int x = 0 + i * 200;
                int y = 0 + i * 200;
                Draw.SetLineColor(0);
                Draw.SetLineSize(10);
                Draw.Line(x, 0, x, 600);
                Draw.Line(0, y, 600, y);
            }





        }
    }

}
