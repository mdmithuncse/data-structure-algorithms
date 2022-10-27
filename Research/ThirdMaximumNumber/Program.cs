using System;
using System.Collections.Generic;

namespace ThirdMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 2, 2, 3, 1 };
            Console.WriteLine($"The output is: { ThirdMax(nums) }");
        }

        static int ThirdMax(int[] nums)
        {
            KeyValuePair<int, bool> firstMax = new KeyValuePair<int, bool>(-1, false);
            KeyValuePair<int, bool> secondMax = new KeyValuePair<int, bool>(-1, false);
            KeyValuePair<int, bool> thirdMax = new KeyValuePair<int, bool>(-1, false);

            for (int i = 0; i < nums.Length; i++)
            {
                if (firstMax.Key == nums[i] || secondMax.Key == nums[i] || thirdMax.Key == nums[i])
                    continue;

                if (!firstMax.Value || firstMax.Key <= nums[i])
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = new KeyValuePair<int, bool>(nums[i], true);
                }

                else if (!secondMax.Value || secondMax.Key <= nums[i])
                {
                    thirdMax = secondMax;
                    secondMax = new KeyValuePair<int, bool>(nums[i], true);
                }

                else if(!thirdMax.Value || thirdMax.Key <= nums[i])
                {
                    thirdMax = new KeyValuePair<int, bool>(nums[i], true);
                }
            }

            if (!thirdMax.Value)
                return firstMax.Key;

            return thirdMax.Key;
        }
    }
}
