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
            return WidthOverlap(cube)
                * HeightOverlap(cube)
                * DepthOverlap(cube);
        }

        private double WidthOverlap(Cube cube)
        {
            return ProjectedSegmentsOverlap(MinX, MaxX, cube.MinX, cube.MaxX);
        }

        private double HeightOverlap(Cube cube)
        {
            return ProjectedSegmentsOverlap(MinY, MaxY, cube.MinY, cube.MaxY);
        }

        private double DepthOverlap(Cube cube)
        {
            return ProjectedSegmentsOverlap(MinZ, MaxZ, cube.MinZ, cube.MaxZ);
        }

        private double ProjectedSegmentsOverlap(double minCoordinate1, double maxCoordinate1, double minCoordinate2, double maxCoordinate2)
        {
            return Math.Max(0, Math.Min(maxCoordinate1, maxCoordinate2) - Math.Max(minCoordinate1, minCoordinate2));
        }

    }
}