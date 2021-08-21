using System;

namespace TwoSumArray
{
    class Program
    {
        // nums = [2,7,11,15], target = 9
        // nums = [3,2,4], target = 6
        // nums = [3,3], target = 6

        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 10, 11, 15, 2, 19, 20, 22, 3, 8, 5, 7 };
            int target = 9;

            //int[] input = new int[] { 2, 7, 11, 15 };
            //int target = 9;

            //int[] input = new int[] { 3, 2, 4 };
            //int target = 6;

            //int[] input = new int[] { 3, 3 };
            //int target = 6;

            int[] output = TwoSumMethod1(input, target);
            Console.WriteLine($"Output: { output }");
        }

        public static int[] TwoSumMethod1(int[] nums, int target)
        {
            int[] output = new int[2];

            for (int i = 0; i <= nums.Length - 2; i++)
            {
                if (nums[i] > target)
                {
                    continue;
                }

                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        output[0] = i;
                        output[1] = j;
                    }
                }
            }

            return output;
        }
    }
}
