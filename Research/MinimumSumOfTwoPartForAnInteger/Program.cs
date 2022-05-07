using System;
using System.Collections.Generic;

namespace MinimumSumOfTwoPartForAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int inputNumber = 857;
            int[] inputNumbers = ConvertToIntArray(inputNumber);
            int[] orderedNumbers = OrderByAscIntArray(inputNumbers);

            Console.WriteLine($"Minimum sum of an integer is: { MinimumSum(orderedNumbers) }");
        }

        public static int MinimumSum(int[] input)
        {
            return input[0] + ConvertToInt(input);
        }

        public static int[] OrderByAscIntArray(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    int temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                }
            }

            return input;
        }

        public static int[] ConvertToIntArray(int input)
        {
            input = Math.Abs(input);
            int length = input.ToString().Length;
            int[] inputNumbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                inputNumbers[i] = input % 10;
                input /= 10;
            }

            return inputNumbers;
        }

        public static int ConvertToInt(int[] input)
        {
            int output = 0;
            int multiplicator = 1;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i] * multiplicator;
                multiplicator *= 10;
            }

            return output;
        }
    }
}
