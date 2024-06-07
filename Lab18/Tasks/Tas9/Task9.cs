namespace Lab18
{
    public static class Task9
    {
        public static Fraction MinFraction(this IEnumerable<Fraction> fractions)
        {
            return fractions.OrderBy(f => f.Value).First();
        }

        public static Fraction MaxFraction(this IEnumerable<Fraction> fractions)
        {
            return fractions.OrderByDescending(f => f.Value).First();
        }
    }
}
