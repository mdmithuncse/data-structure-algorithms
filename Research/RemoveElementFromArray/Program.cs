using System;

namespace RemoveElementFromArray
{
    class Program
    {
        /* Input: [3,2,2,3], 3
           Output: 2
           Input: [0,1,2,2,3,0,4,2], 2 
           Output: 5
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] input = new int[] { 3, 2, 2, 3 };
            //int target = 3;
            int[] input = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int target = 2;
            Console.WriteLine($"The output is: {RemoveElement(input, target)}");
        }

        static int RemoveElement(int[] nums, int val)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}
