using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBallsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Rack newRack = new Rack();
            int[] ballRack = newRack.DrawRandomBalls();

            for(var i = 0; i < ballRack.Length; i++)
            {
                Console.WriteLine(ballRack[i]);
            }
        }
    }
}
