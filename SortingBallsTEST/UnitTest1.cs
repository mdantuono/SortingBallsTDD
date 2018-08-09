using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingBallsKata;

namespace SortingBallsTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyTest()
        {
            Rack rack = new Rack();
            int[] emptyArray = rack.DrawNoBalls();
            int[] expectedOutput = new int[] { };

            CollectionAssert.AreEqual(emptyArray, expectedOutput);
        }

        [TestMethod]
        public void ThreeNumberTest()
        {
            Rack rack = new Rack();
            int[] rackArray = rack.DrawThreeBalls();

            int[] expectedOutput = new int[] { 1, 2, 3 };

            CollectionAssert.AreEqual(rackArray, expectedOutput);
        }

        [TestMethod]
        public void ThreeBallSort()
        {
            Rack rack = new Rack();
            int[] rackArray = rack.SortThreeBalls();

            int[] expectedOutput = new int[] { 1, 2, 3 };

            CollectionAssert.AreEqual(rackArray, expectedOutput);
        }

        [TestMethod]
        public void KeepAddingBalls()
        {
            Rack rack = new Rack();

            int[] rackArray = rack.DrawNoBalls();
            int[] expectedOutput = new int[] { };
            CollectionAssert.AreEqual(rackArray, expectedOutput);
            // Should return array of no size

            rackArray[0] = rack.AddBall(0);
            expectedOutput = new int[] { 0 };
            CollectionAssert.AreEqual(rackArray, expectedOutput);


            rackArray[1] = rack.AddBall(1);
            expectedOutput = new int[] { 0, 1 };
            CollectionAssert.AreEqual(rackArray, expectedOutput);

        }
    }
}
