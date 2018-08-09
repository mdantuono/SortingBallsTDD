using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBallsKata
{
    public class Rack
    {
        public Rack()
        { }

        public int[] DrawNoBalls()
        {
            int[] balls = new int[] { };
            return balls;
        }

        public int AddBall(int number)
        {
            return number;
        }
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
            // Chooses number of balls drawn between 1 and 15
            int numBalls = rnd.Next(1, 15);
            // Creates array of size of how many balls
            int[] balls = new int[numBalls];
            // Loop to choose balls between 0 and 59
            for (var i = 0; i < numBalls; i++)
            {
                balls[i] = rnd.Next(0, 59);
            }

            Array.Sort(balls);
            return balls;
        }

    }
}
