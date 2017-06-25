using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CubesExercise.CubeBuilder;

namespace CubesExercise
{
    [TestClass]
    public class CubeIntersectionShould
    {

        [TestMethod]
        public void be_zero_when_cubes_do_not_intersect()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(0, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_height_and_depth_fixed()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(3, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_width_and_depth_fixed()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 3, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_correct_for_intersecting_cubes_with_width_and_height_fixed()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 3).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(4, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_equal_to_the_volume_of_the_smaller_cube_when_it_is_contained_by_the_bigger_cube()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(1).Build();

            Assert.AreEqual(1, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(1, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_equal_to_the_volume_of_any_cube_when_they_are_the_same()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(8, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(8, cubeB.IntersectionVolumeWith(cubeA));
        }

        [TestMethod]
        public void be_zero_when_cubes_are_touching_but_not_intersecting()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(4, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
            Assert.AreEqual(0, cubeB.IntersectionVolumeWith(cubeA));
        }
    }
    class CubeBuilder
    {
        private Point center;
        private double edgeLength;
        public static CubeBuilder Cube()
        {
            return new CubeBuilder();
        }
        public CubeBuilder CenteredAt(double x, double y, double z)
        {
            center = new Point(x, y, z);
            return this;
        }
        public CubeBuilder WithEdgeLength(double length)
        {
            edgeLength = length;
            return this;
        }
        public Cube Build()
        {
            return new Cube(center, edgeLength);
        }
    }
}
