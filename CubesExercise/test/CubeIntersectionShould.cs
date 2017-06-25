using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubesExercise
{
    [TestClass]
    public class CubeIntersectionShould
    {
        [TestMethod]
        public void be_zero_when_cubes_do_not_intersect()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 1);
            Cube cubeB = new Cube(new Point(10, 10, 10), 1);

            Assert.AreEqual(0, cubeA.intersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_height_and_depth_fixed()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(3, 2, 2), 2);

            Assert.AreEqual(4, cubeA.intersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.intersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_width_and_depth_fixed()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(2, 3, 2), 2);

            Assert.AreEqual(4, cubeA.intersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.intersectionVolumeWith(cubeA));
        }
    }
}
