namespace Lab18
{
    public static class Task8
    {
        public static void MaxDistance(IEnumerable<Point3D> points)
        {
            double maxDistance = 0;
            Point3D point1 = null;
            Point3D point2 = null;

            var pointArray = points.ToArray();
            for (int i = 0; i < pointArray.Length; i++)
            {
                for (int j = i + 1; j < pointArray.Length; j++)
                {
                    double distance = pointArray[i].DistanceTo(pointArray[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        point1 = pointArray[i];
                        point2 = pointArray[j];
                    }
                }
            }

            Console.WriteLine($"Max distance: {maxDistance} between {point1} and {point2}");
        }

        public static void SaveToFile(IEnumerable<Point3D> points, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var point in points)
                {
                    writer.WriteLine($"{point.X},{point.Y},{point.Z}");
                }
            }
        }

        public static List<Point3D> LoadFromFile(string filePath)
        {
            var points = new List<Point3D>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    var point = new Point3D(double.Parse(parts[0]), double.Parse(parts[1]), double.Parse(parts[2]));
                    points.Add(point);
                }
            }
            return points;
        }
    }
}
