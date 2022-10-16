using System;

namespace CountEvenDigitArray
{
    class Program
    {
        // nums: [2, 10, 2562, 563, 789]
        // output: 2
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 2, 10, 2562, 563, 789 };
            Console.WriteLine($"The output is: { CountEvenDigit(nums) }");
        }

        static int CountEvenDigit(int[] nums)
        {
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                int length = 0;

                while (nums[i] != 0)
                {
                    nums[i] = nums[i] / 10;
                    length++;
                }

                if (length % 2 == 0)
                    count++;
            }

            return count;
        }
    }
}
