using System;

namespace LargestElementArray
{
    class Program
    {
        // n = 5
        // A[] = {1, 8, 7, 56, 90}

        //n = 7
        //A[] = {1, 2, 0, 3, 2, 4, 5}
        static void Main(string[] args)
        {
            //int[] input = new int[] { 1, 8, 7, 56, 90 };
            int[] input = new int[] { 1, 2, 0, 3, 2, 4, 5 };
            int output = Largest(input, 7);
            Console.WriteLine($"Largest element in array: { output }");
        }

        public static int Largest(int [] input, int n)
        {
            int max = input[0];

            for(int i = 1; i < n; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }

            return max;
        }
    }
}
