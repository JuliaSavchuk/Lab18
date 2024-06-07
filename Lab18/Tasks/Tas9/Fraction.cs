namespace Lab18
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public double Value => (double)Numerator / Denominator;

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static void SaveFractionsToFile(IEnumerable<Fraction> fractions, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var fraction in fractions)
                {
                    writer.WriteLine($"{fraction.Numerator},{fraction.Denominator}");
                }
            }
        }

        public static List<Fraction> LoadFractionsFromFile(string filePath)
        {
            var fractions = new List<Fraction>();
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    var fraction = new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
                    fractions.Add(fraction);
                }
            }
            return fractions;
        }
    }
}
