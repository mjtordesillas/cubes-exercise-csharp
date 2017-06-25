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

        public double MinX
        {
            get { return point.X - ProjectedDistanceFromCenter; }
        }

        public double MaxX
        {
            get { return point.X + ProjectedDistanceFromCenter; }
        }

        private double ProjectedDistanceFromCenter
        {
            get { return edgeLength / 2.0; }
        }

        public double intersectionVolumeWith(Cube cube)
        {
            if (MaxX >= cube.MinX && MinX <= cube.MaxX )
            {
                return widthOverlap(cube)
                    * edgeLength
                    * edgeLength;
            }
            else
            {
                return 0;
            }
        }

        private double widthOverlap(Cube cube)
        {
            return Math.Max(0, Math.Min(MaxX, cube.MaxX) - Math.Max(MinX, cube.MinX));
        }
    }
}