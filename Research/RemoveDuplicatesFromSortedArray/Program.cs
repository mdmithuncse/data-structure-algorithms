using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine($"Output is: {RemoveDuplicates(input)}");
            //int[] nums = new int[] { 10, 2, 5, 3 };
            int[] nums = new int[] { 7, 1, 14, 11 };
            Console.WriteLine($"Output is: { CheckIfNAndItsDuplicateExists(nums) }");
        }

        static bool CheckIfNAndItsDuplicateExists(int[] nums)
        {
            HashSet<int> items = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(items.Contains(2 * nums[i]) || (nums[i] % 2 == 0 && items.Contains(nums[i] / 2)))
                {
                    return true;
                }

                items.Add(nums[i]);
            }

            return false;
        }

        static int RemoveDuplicates(int[] nums)
        {
            int insertIndex = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[insertIndex] = nums[i];
                    insertIndex++;
                }
            }

            return insertIndex;
        }
    }
}
