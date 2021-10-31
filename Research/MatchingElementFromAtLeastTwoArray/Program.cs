using System;
using System.Collections.Generic;

namespace MatchingElementFromAtLeastTwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] nums1 = new int[] { 1, 1, 3, 2 };
            //int[] nums2 = new int[] { 2, 3 };
            //int[] nums3 = new int[] { 3 };
            // Output [3, 2]

            //int[] nums1 = new int[] { 3, 1 };
            //int[] nums2 = new int[] { 2, 3 };
            //int[] nums3 = new int[] { 1, 2 };
            // Output [2,3,1]

            int[] nums1 = new int[] { 1, 2, 2 };
            int[] nums2 = new int[] { 4, 3, 3 };
            int[] nums3 = new int[] { 5 };
            // Output:[]

            IList<int> output = TwoOutOfThree(nums1, nums2, nums3);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }
        }

        public static IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            if (nums1.Length == 0 && nums2.Length == 0 && nums3.Length == 0) return default;
            IList<int> output = new List<int>();

            for (int a = 1; a <= 100; a++)
            {
                int i = 0;
                int j = 0;
                int k = 0;
                int count = 0;

                while (i < nums1.Length)
                {
                    if (nums1[i] == a)
                    {
                        count++;

                        break;
                    }

                    i++;
                }

                while (j < nums2.Length)
                {
                    if (nums2[j] == a)
                    {
                        count++;

                        break;
                    }

                    j++;
                }

                while (k < nums3.Length)
                {
                    if (nums3[k] == a)
                    {
                        count++;

                        break;
                    }

                    k++;
                }

                if (count > 1)
                    output.Add(a);
            }

            return output;
        }
    }
}
