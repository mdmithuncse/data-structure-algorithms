using System;

namespace MaximumNumberOfWordsFoundInSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] sentences = new string[]
            {
                "alice and bob love leetcode",
                "i think so too",
                "this is great thanks very much"
            };
            Console.WriteLine($"The output is: { MostWordsFound(sentences) }");
        }

        public static int MostWordsFound(string[] sentences)
        {
            int max = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                max = Math.Max(max, sentences[i].Split(' ').Length);
            }

            return max;
        }
    }
}
