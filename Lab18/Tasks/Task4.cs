namespace Lab18
{
    public static class Task4
    {
        public static int CountVowels(this string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return str.Count(c => vowels.Contains(c));
        }
    }
}
