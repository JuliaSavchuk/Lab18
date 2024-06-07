namespace Lab18
{
    public static class Task6
    {
        public static int CountSentences(this string str)
        {
            char[] sentenceEndings = { '.', '!', '?' };
            return str.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
