using System;
using System.Collections.Generic;

namespace FindAllNumbersDisappearedInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            //int[] nums = new int[] { 1, 1 };
            Console.WriteLine($"The output is: {FindDisappearedNumbers(nums)}");
        }

        static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> items = new List<int>();

            for (int i = 1; i <= nums.Length; i++)
            {
                items.Add(i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (items.Contains(nums[i]))
                    items.Remove(nums[i]);
            }

            return items;
        }
    }
}
