namespace Lab18
{
    public static class Task5
    {
        public static int CountConsonants(this string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return str.Count(c => char.IsLetter(c) && !vowels.Contains(c));
        }
    }
}
