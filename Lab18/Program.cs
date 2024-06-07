namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 12;
            int number2 = 5;
            string sentence = "Hello World. How are you? I am fine!";

            Console.WriteLine("-----Task 1-----\n");
            Console.WriteLine($"{number1} is odd: {number1.IsOdd()}");

            Console.WriteLine("\n\n-----Task 2-----\n");
            Console.WriteLine($"{number1} is even: {number1.IsEven()}");
            Console.WriteLine($"{number2} is even: {number2.IsEven()}");

            Console.WriteLine("\n\n-----Task 3-----\n");
            Console.WriteLine($"{number1} is prime: {number1.IsPrime()}");
            Console.WriteLine($"{number2} is prime: {number2.IsPrime()}");

            Console.WriteLine("\n\n-----Task 4-----\n");
            Console.WriteLine($"Number of vowels in '{sentence}': {sentence.CountVowels()}");

            Console.WriteLine("\n\n-----Task 5-----\n");
            Console.WriteLine($"Number of consonants in '{sentence}': {sentence.CountConsonants()}");

            Console.WriteLine("\n\n-----Task 6-----\n");
            Console.WriteLine($"Number of sentences in text: {sentence.CountSentences()}");

            Console.WriteLine("\n\n-----Task 7-----\n");
            var people = new List<Person>
            {
                new Person("John", "Doe", 25),
                new Person("Jane", "Smith", 30),
                new Person("Sam", "Brown", 20)
            };

            // Зберегти масив записів у файл
            Task7.SaveToFile(people, "people.txt");

            // Завантажити масив записів з файлу
            var loadedPeople = Task7.LoadFromFile("people.txt");

            // Знайти людину з мінімальним і максимальним віком
            Task7.FindAgeExtremes(loadedPeople);

            // Відобразити середній вік людей
            Console.WriteLine($"Average age: {loadedPeople.AverageAge()}");

            Console.WriteLine("\n\n-----Task 8-----\n");
            var points = new List<Point3D>
            {
                new Point3D(0, 0, 0),
                new Point3D(3, 4, 5),
                new Point3D(6, 8, 10)
            };

            Task8.SaveToFile(points, "points.txt");
            var loadedPoints = Task8.LoadFromFile("points.txt");
            Task8.MaxDistance(loadedPoints);

            Console.WriteLine("\n\n-----Task 9-----\n");
            var fractions = new List<Fraction>
        {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(5, 8),
            new Fraction(7, 10)
        };

            string filePath9 = "fractions.txt";
            Fraction.SaveFractionsToFile(fractions, filePath9);

            var loadedFractions = Fraction.LoadFractionsFromFile(filePath9);
            var minFraction = loadedFractions.MinFraction();
            var maxFraction = loadedFractions.MaxFraction();

            Console.WriteLine($"Min fraction: {minFraction}");
            Console.WriteLine($"Max fraction: {maxFraction}");


        }


    }
}
