using System;
using System.Collections.Generic;

namespace TwoSumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = new int[] { 1, 10, 11, 15, 2, 19, 20, 22, 3, 8, 5, 7 };
            //int target = 9;

            //int[] input = new int[] { 2, 7, 11, 15 };
            //int target = 9;

            //int[] input = new int[] { 3, 2, 4 };
            //int target = 6;

            //int[] input = new int[] { 3, 3 };
            //int target = 6;

            int[] input = new int[] { -1, -2, -3, -4, -5 };
            int target = 8;

            //int[] input = new int[] { -3, -2, 3, 90};
            //int target = 0;

            int[] output = TwoSum(input, target);
            Console.WriteLine($"Output: [{ output[0] }, {output[1]}]");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }

                map.Remove(nums[i]);
                map.Add(nums[i], i);
            }

            return default;

        }
    }
}
