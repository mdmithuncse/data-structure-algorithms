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
            KeyValuePair<long, bool> firstMax = new KeyValuePair<long, bool>(long.MinValue, false);
            KeyValuePair<long, bool> secondMax = new KeyValuePair<long, bool>(long.MinValue, false);
            KeyValuePair<long, bool> thirdMax = new KeyValuePair<long, bool>(long.MinValue, false);

            for (int i = 0; i < nums.Length; i++)
            {
                if (firstMax.Key == nums[i] || secondMax.Key == nums[i] || thirdMax.Key == nums[i])
                    continue;

                if (!firstMax.Value || firstMax.Key <= nums[i])
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = new KeyValuePair<long, bool>(nums[i], true);
                }

                else if (!secondMax.Value || secondMax.Key <= nums[i])
                {
                    thirdMax = secondMax;
                    secondMax = new KeyValuePair<long, bool>(nums[i], true);
                }

                else if(!thirdMax.Value || thirdMax.Key <= nums[i])
                {
                    thirdMax = new KeyValuePair<long, bool>(nums[i], true);
                }
            }

            if (!thirdMax.Value)
                return (int)firstMax.Key;

            return (int)thirdMax.Key;
        }
    }
}
