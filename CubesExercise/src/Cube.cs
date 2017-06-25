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
                return (MaxX - cube.MinX)
                    * edgeLength
                    * edgeLength;
            }
            else
            {
                return 0;
            }
        }
    }
}