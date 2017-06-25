using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CubesExercise.test.CubeBuilder;

namespace CubesExercise
{
    [TestClass]
    public class CubeCollisionDetectionTest
    {

        [TestMethod]
        public void cubes_that_do_not_touch()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            Assert.IsFalse(cubeA.CollidesWith(cubeB));
        }

        [TestMethod]
        public void cubes_that_overlap()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(3, 2, 2).WithEdgeLength(2).Build();

            Assert.IsTrue(cubeA.CollidesWith(cubeB));
        }

        [TestMethod]
        public void cubes_that_touch()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(4, 2, 2).WithEdgeLength(2).Build();

            Assert.IsTrue(cubeA.CollidesWith(cubeB));
        }
    }
}
