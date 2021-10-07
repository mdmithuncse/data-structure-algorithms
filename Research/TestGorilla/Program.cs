using System;
using System.Linq;

namespace TestGorilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "abbcd1";
            bool result1 = CheckLength(input);
            bool result2 = CheckUnique(input);
            bool result3 = CheckDigit(input);
            int result4 = ReturnSubstringCount(input);
            Console.WriteLine($"This is test");
        }

        private static int ReturnSubstringCount(string input)
        {
            var max = 0;
            var count = 0;

            for (var i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] == 49)
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }

                    count = 0;
                }
            }

            if (count > max)
                max = count;

            return max;
        }

        private static bool CheckLength(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if (input.Length == 4 || input.Length == 6)
            {
                return true;
            }

            return false;
        }

        private static bool CheckUnique(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool CheckDigit(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            bool isDigit = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 48 || input[i] == 49 || input[i] == 50 ||
                    input[i] == 51 || input[i] == 52 || input[i] == 53 ||
                    input[i] == 54 || input[i] == 55 || input[i] == 56 ||
                    input[i] == 57)
                {
                    isDigit = true;

                    break;
                }
            }

            return isDigit;
        }
    }
}
