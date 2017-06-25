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
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(10, 10, 10), 2);

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(0, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_height_and_depth_fixed()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(3, 2, 2), 2);

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_width_and_depth_fixed()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(2, 3, 2), 2);

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_width_and_height_fixed()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(2, 2, 3), 2);

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_equal_to_the_volume_of_the_smaller_cube_when_it_is_contained_by_the_bigger_cube()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(2, 2, 2), 1);

            Assert.AreEqual(1, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(1, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_equal_to_the_volume_of_any_cube_when_they_are_the_same()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(2, 2, 2), 2);

            Assert.AreEqual(8, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(8, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_zero_when_cubes_are_touching_but_not_intersecting()
        {
            Cube cubeA = new Cube(new Point(2, 2, 2), 2);
            Cube cubeB = new Cube(new Point(4, 2, 2), 2);

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(0, cubeB.IntersectionVolumeWith(cubeA));
        }
    }
}
