using System;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Input: nums1 = [1,3], nums2 = [2]
            // Input: nums1 = [1,2], nums2 = [3,4]
            // Input: nums1 = [0,0], nums2 = [0,0]
            // Input: nums1 = [], nums2 = [1]
            // nums1 = [2], nums2 = []
            int[] nums1 = new int[2] { 1, 3 };
            int[] nums2 = new int[1] { 2 };

            var result = FindMedianSortedArrays(nums1, nums2);

            Console.WriteLine($"The output is: {result}");
        }

        private static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] tempArray = new int[nums1.Length + nums2.Length];

            Array.Copy(nums1, 0, tempArray, 0, nums1.Length);
            Array.Copy(nums2, 0, tempArray, (nums1.Length - 1) + 1, nums2.Length);

            for (int i = 0; i < tempArray.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < tempArray.Length - i - 1; j++)
                {
                    if (tempArray[j] > tempArray[j + 1])
                    {
                        int temp = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return 0.00;
        }
    }
}
