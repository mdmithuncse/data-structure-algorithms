using System;

namespace MoveZerosToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 0, 1, 0, 3, 12 };

            //Output: [1,3,12,0,0]

            Console.WriteLine($"The output is: { MoveZeroes(nums) }");
        }

        static int[] MoveZeroes(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    int j = i + 1;

                    while(j < nums.Length)
                    {
                        if(nums[j] != 0)
                        {
                            int temp = nums[i];

                            nums[i] = nums[j];
                            nums[j] = temp;

                            break;
                        }

                        j++;
                    }
                }
            }

            return nums;
        }
    }
}