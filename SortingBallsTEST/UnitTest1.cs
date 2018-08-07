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
            int[] emptyArray = new int[] { };
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
    }
}
