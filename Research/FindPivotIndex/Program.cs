using System;

namespace FindPivotIndex
{
    class Program
    {
        // [1,7,3,6,5,6]
        // 3
        // [1,2,3]
        // -1
        // [2,1,-1]
        // 0
        // [-1, 1, 2]
        // 2
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 7, 3, 6, 5, 6 };
            Console.WriteLine($"The output is: { FindPivotIndex(nums) }");
        }

        static int FindPivotIndex(int[] nums)
        {
            int pivotIndex = -1;
            int leftIndex = 0;
            int rightIndex = nums.Length;
            int midIndex = leftIndex + (rightIndex - leftIndex) / 2;
            int i = midIndex - 1;
            int j = midIndex + 1;
            int leftSum = 0;
            int rightSum = 0;

            if (midIndex == 0)
                return pivotIndex;

            if (midIndex == 1)
            {
                if (leftIndex == nums[midIndex] + nums[rightIndex - 1])
                {
                    pivotIndex = leftIndex;

                    return pivotIndex;
                }

                else if(leftIndex == nums[midIndex] + nums[leftIndex])
                {
                    pivotIndex = rightIndex - 1;

                    return pivotIndex;
                }
            }

            if(midIndex > 0)
            {
                while(i >= leftIndex)
                {
                    leftSum += nums[i--];
                }

                while(j < rightIndex)
                {
                    rightSum += nums[j++];
                }

                if (leftSum == rightSum)
                {
                    pivotIndex = midIndex;

                    return pivotIndex;
                }       
            }

            return pivotIndex;
        }
    }
}
