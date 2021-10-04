using System;
using System.Linq;

namespace FindNextHigherNumberWithSameDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int NextNumber(int input)
        {
            if (input == 0)
            {
                return 0;
            }

            int[] inputArray = input.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();

            int startIndex = inputArray.Length - 1;
            int endIndex = 0;
            int d1, d2;
            int d1Index, d2Index;

            for (int i = startIndex; i <= endIndex; i--)
            {
                if (inputArray[i] > inputArray[i - 1])
                {
                    d1 = inputArray[i - 1];
                    d1Index = i - 1;
                }
            }

            for (int i = d1Index; i < startIndex; i++)
            {

            }
        }
    }
}
