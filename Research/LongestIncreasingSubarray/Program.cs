using System;

namespace LongestIncreasingSubarray
{
    class Program
    {
        /*Input : arr[] = {5, 6, 3, 5, 7, 8, 9, 1, 2}
        Output : 5
        The subarray is {3, 5, 7, 8, 9}

        Input : arr[] = {12, 13, 1, 5, 4, 7, 8, 10, 10, 11}
        Output: 4
        The subarray is {4, 7, 8, 10}*/
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] input = new int[] { 5, 6, 3, 5, 7, 8, 9, 1, 2 };
            Console.WriteLine($"Length of longest increasing sub array is: {LengthOfLongestIncreasingSubArray(input)}");
        }

        public static int LengthOfLongestIncreasingSubArray(int[] input)
        {
            int max = 1;
            int length = 1;

            for (int i = 1; i < input.Length; i++)
            {
                int a = input[i];
                int b = input[i - 1];

                if (input[i] > input[i-1])
                {
                    length++;
                }

                else
                {
                    if (max < length)
                        max = length;

                    length = 1;
                }
            }

            if (max < length)
                max = length;

            return max;
        }
    }
}