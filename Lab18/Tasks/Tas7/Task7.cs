namespace Lab18
{
    public static class Task7
    {
        public static double AverageAge(this IEnumerable<Person> people)
        {
            return people.Average(person => person.Age);
        }

        public static void FindAgeExtremes(IEnumerable<Person> people)
        {
            var minAgePerson = people.OrderBy(person => person.Age).First();
            var maxAgePerson = people.OrderByDescending(person => person.Age).First();

            Console.WriteLine($"Person with minimum age: {minAgePerson}");
            Console.WriteLine($"Person with maximum age: {maxAgePerson}");
        }

        public static void SaveToFile(IEnumerable<Person> people, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var person in people)
                {
                    writer.WriteLine($"{person.FirstName},{person.LastName},{person.Age}");
                }
            }
        }

        public static List<Person> LoadFromFile(string filePath)
        {
            var people = new List<Person>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    var person = new Person(parts[0], parts[1], int.Parse(parts[2]));
                    people.Add(person);
                }
            }
            return people;
        }
    }
}
