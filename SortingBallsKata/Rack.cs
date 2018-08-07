using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBallsKata
{
    public class Rack
    {
        public int[] DrawThreeBalls()
        {
            int[] balls = new int[] { 1, 2, 3 };

            return balls;

        }

        public int[] SortThreeBalls()
        {
            int[] balls = new int[] { 3, 2, 1 };

            Array.Sort(balls);
            return balls;
        }

        public int[] DrawRandomBalls()
        {
            // RANDOM BALL GENERATION CODE
            // Instantiate new random class
            Random rnd = new Random();
            int numBalls = rnd.Next(1, 15);
            int[] balls = new int[numBalls];
            for (var i = 0; i < numBalls; i++)
            {
                balls[i] = rnd.Next(0, 59);
            }

            Array.Sort(balls);
            return balls;
        }

    }
}
