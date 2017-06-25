using System;

namespace CubesExercise
{
    public class Cube
    {
        private Point point;
        private double edgeLength;

        public Cube(Point point, double edgeLength)
        {
            this.point = point;
            this.edgeLength = edgeLength;
        }

        private double MinX
        {
            get { return point.X - ProjectedDistanceFromCenter; }
        }

        private double MaxX
        {
            get { return point.X + ProjectedDistanceFromCenter; }
        }

        private double MinY
        {
            get { return point.Y - ProjectedDistanceFromCenter; }
        }

        private double MaxY
        {
            get { return point.Y + ProjectedDistanceFromCenter; }
        }

        private double MinZ
        {
            get { return point.Z - ProjectedDistanceFromCenter; }
        }

        private double MaxZ
        {
            get { return point.Z + ProjectedDistanceFromCenter; }
        }

        private double ProjectedDistanceFromCenter
        {
            get { return edgeLength / 2.0; }
        }

        public double IntersectionVolumeWith(Cube cube)
        {
            if (MaxX >= cube.MinX && MinX <= cube.MaxX )
            {
                return WidthOverlap(cube)
                    * HeightOverlap(cube)
                    * DepthOverlap(cube);
            }
            else
            {
                return 0;
            }
        }

        private double WidthOverlap(Cube cube)
        {
            return Math.Max(0, Math.Min(MaxX, cube.MaxX) - Math.Max(MinX, cube.MinX));
        }

        private double HeightOverlap(Cube cube)
        {
            return Math.Max(0, Math.Min(MaxY, cube.MaxY) - Math.Max(MinY, cube.MinY));
        }

        private double DepthOverlap(Cube cube)
        {
            return Math.Max(0, Math.Min(MaxZ, cube.MaxZ) - Math.Max(MinZ, cube.MinZ));
        }
    }
}