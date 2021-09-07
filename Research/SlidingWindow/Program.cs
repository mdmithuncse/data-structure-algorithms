using System;
using System.Collections.Generic;

namespace SlidingWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "ababaackkkbb";

            Console.WriteLine($"Result: {SlidingWindow(input)}");
        }

        static string SlidingWindow(string input)
        {
            string output = string.Empty;

            for (int i = 0; i < input.Length - 3; i++)
            {
                bool result = IsUnique(input.Substring(i, 3));

                if (result)
                {
                    output = input.Substring(i, 3);
                }
            }

            return output;
        }

        static bool IsUnique(string input)
        {
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {
                set.Add(input[i]);
            }

            return set.Count == 3 ? true : false;
        }
    }
}
