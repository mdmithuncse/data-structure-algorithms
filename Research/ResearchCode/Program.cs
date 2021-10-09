using System;
using System.Collections.Generic;

namespace ResearchCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[4] { 2, 7, 11, 15 };
            int target = 9;
            var results = TwoSum(input, target);
            Console.WriteLine($"The output is:");
            foreach (var result in results)
                Console.WriteLine($"{result}");
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

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
