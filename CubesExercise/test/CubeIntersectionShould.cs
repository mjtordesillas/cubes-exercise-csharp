using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubesExercise
{
    [TestClass]
    public class CubeIntersectionShould
    {
        [TestMethod]
        public void return_zero_when_cubes_do_not_intersect()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 1);
            Cube cubeB = new Cube(new Point(10, 10, 10), 1);

            Assert.AreEqual(0, cubeA.intersectionVolumeWith(cubeB));
        }
    }
}
