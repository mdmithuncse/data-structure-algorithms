using System;

namespace TestBolt
{
    class Program
    {
        // Example input: I drive with Bolt
        // Example output: I evird htiw tloB
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] input = new char[] { 'W', 'e', ' ', 'd', 'r', 'i', 'v', 'e', ' ', 'w', 'i', 't', 'h', ' ', 'B', 'o', 'l', 't', ' ' };
            char[] output = ReverseWords(input);
            Console.WriteLine($"The result is:");
        }

        public static char[] ReverseWords(char[] input)
        {
            int prevStartIndex = 0;
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    startIndex = i;
                    endIndex = i - 1;

                    if (endIndex <= 0)
                    {
                        prevStartIndex = startIndex;

                        continue;
                    }
                }

                if (i == input.Length - 1)
                {
                    endIndex = i;
                }

                if (endIndex > prevStartIndex)
                {
                    for (int j = prevStartIndex + 1, k = endIndex; j < k; j++, k--)
                    {
                        char c = input[j];
                        input[j] = input[k];
                        input[k] = c;
                    }

                    prevStartIndex = endIndex + 1;
                }
            }

            return input;
        }
    }
}
