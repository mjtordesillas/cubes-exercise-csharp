﻿using System;

namespace CubesExercise
{
    public class Cube
    {
        private Point Center { get; }
        private double EdgeLength { get; }

        private Edge width;
        private Edge height;
        private Edge depth;

        public Cube(Point center, double edgeLength)
        {
            Center = center;
            EdgeLength = edgeLength;
            width = new Edge(center.X, EdgeLength);
            height = new Edge(center.Y, EdgeLength);
            depth = new Edge(center.Z, EdgeLength);
        }

        public double IntersectionVolumeWith(Cube cube)
        {
            return Math.Max(0, width.Overlap(cube.width))
                * Math.Max(0, height.Overlap(cube.height))
                * Math.Max(0, depth.Overlap(cube.depth));
        }

        public bool CollidesWith(Cube cube)
        {
            return width.Overlap(cube.width) >= 0
                || height.Overlap(cube.height) >= 0
                || depth.Overlap(cube.depth) >= 0 ;
        }
    }
}