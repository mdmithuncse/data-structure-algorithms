using System;
using System.Collections.Generic;

namespace TestJetAbroad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"Output is: { Sum(1, 1000) }");
            string input = "This is a string";
            Console.WriteLine($"Output is: { CountLetterOccurrences(input, 2) }");
        }

        public static int Sum(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int CountLetterOccurrences(string input, int minOccurrences)
        {
            int count = 0;

            IDictionary<char, int> hashSet = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                int occurence = 0;

                if (char.ToLower(input[i]) >= 97 && char.ToLower(input[i]) <= 122)
                {
                    if (!hashSet.ContainsKey(char.ToLower(input[i])))
                    {
                        occurence++;

                        hashSet.Add(char.ToLower(input[i]), occurence);
                    }

                    else
                    {
                        occurence = hashSet[char.ToLower(input[i])];
                        occurence++;

                        hashSet.Remove(char.ToLower(input[i]));
                        hashSet.Add(char.ToLower(input[i]), occurence);
                    }
                }
            }

            foreach(var item in hashSet)
            {
                if (item.Value >= minOccurrences)
                    count++;
            }

            return count;
        }

    }
}
