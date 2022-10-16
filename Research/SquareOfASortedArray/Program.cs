using System;

namespace SquareOfASortedArray
{
    class Program
    {
        /*Input: nums = [-4, -1, 0, 3, 10]
          Output:[0,1,9,16,100]
          Explanation: After squaring, the array becomes[16, 1, 0, 9, 100].
          After sorting, it becomes[0, 1, 9, 16, 100].

          Input: nums = [-7, -3, 2, 3, 11]
          Output:[4,9,9,49,121]*/

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputs = new int[] { -4, -1, 0, 3, 10 };
            Console.WriteLine($"The output is: {SortedSquares(inputs)}");
        }

        static int[] SortedSquares(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
