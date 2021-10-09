using System;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Test sucess
            int[] nums1 = new int[2] { 1, 3 };
            int[] nums2 = new int[1] { 2 };
            // Median is: 2.00000

            // Test success
            //int[] nums1 = new int[2] { 1, 2 };
            //int[] nums2 = new int[2] { 3, 4 };
            // Median is: 2.50000

            // Test failed
            //int[] nums1 = new int[2] { 0, 0 };
            //int[] nums2 = new int[2] { 0, 0 };
            // Median is: 0.00000

            // Test success
            //int[] nums1 = new int[] { };
            //int[] nums2 = new int[1] { 1 };
            // Median is: 1.00000

            // Test failed
            //int[] nums1 = new int[1] { 2 };
            //int[] nums2 = new int[] { };
            // Median is: 2.00000

            double result = FindMedianSortedArrays(nums1, nums2);

            Console.WriteLine($"The output is: {(double)result}");
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

            double medianValue = 0;

            if (tempArray.Length % 2 == 0)
            {
                // count is even, need to get the middle two elements, add them together, then divide by 2
                int middleElement1 = tempArray[(tempArray.Length / 2) - 1];
                int middleElement2 = tempArray[tempArray.Length / 2];

                medianValue = (double)(middleElement1 + middleElement2) / 2;
            }

            else
            {
                // count is odd, simply get the middle element.
                medianValue = tempArray[tempArray.Length / 2];
            }

            return medianValue;
        }
    }
}
