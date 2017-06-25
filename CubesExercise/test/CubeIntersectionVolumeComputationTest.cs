using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CubesExercise.test.CubeBuilder;

namespace CubesExercise
{
    [TestClass]
    public class CubeIntersectionVolumeComputationTest
    {

        [TestMethod]
        public void cubes_that_do_not_intersect()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void cubes_with_same_height_and_depth()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(3, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void cubes_with_same_width_and_depth()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 3, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void cubes_with_same_width_and_height()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 3).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void one_cube_is_contained_within_the_other()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(1).Build();

            Assert.AreEqual(1, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void cubes_are_completely_overlapped()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(8, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void cubes_are_touching_but_not_intersecting()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(4, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void is_commutative()
        {
            var cubeA = Cube().CenteredAt(0, 0, 0).WithEdgeLength(3).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(cubeA.IntersectionVolumeWith(cubeB),
                cubeB.IntersectionVolumeWith(cubeA));
        }
    }
}
