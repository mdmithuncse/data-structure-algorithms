using System;
using System.Linq;

namespace TestGorilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "11111111";
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

            string value1 = string.Empty;
            string value2 = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                value1 = input.Substring(i, 1);

                for (int j = 0; j < input.Length; j++)
                {
                    value2 = input.Substring(j, 1);

                    if ((value1 == value2) && (i != j))
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

            foreach (char character in input)
            {
                if (character < '0' || character > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
