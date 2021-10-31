using System;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine($"Output is: {RemoveDuplicates(input)}");
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
