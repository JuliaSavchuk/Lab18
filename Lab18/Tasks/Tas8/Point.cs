namespace Lab18
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point3D other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) +
                             Math.Pow(Y - other.Y, 2) +
                             Math.Pow(Z - other.Z, 2));
        }

        public override string ToString()
        {
            return $"Point({X}, {Y}, {Z})";
        }

    }
}
