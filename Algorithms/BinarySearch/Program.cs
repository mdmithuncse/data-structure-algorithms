using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Binary search : " + BinarySearch(new int[] { 1, 3, 5, 7, 8 }, 5));
            Console.WriteLine("Binary search : " + BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 0));
            Console.WriteLine("Binary search : " + BinarySearch(new int[] { 2, 8, 89, 120, 1000 }, 120));
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            // <= here because left and right could point to the same element, < would miss it
            while (left <= right)
            {
                // use `(right - left) /2` to prevent `left + right` potential overflow
                int mid = left + (right - left) / 2;
                // found target, return its index
                if (arr[mid] == target) return mid;

                if (arr[mid] < target)
                {
                    // middle less than target, discard left half by making left search boundary `mid + 1`
                    left = mid + 1;
                }

                else
                {
                    // middle greater than target, discard right half by making right search boundary `mid - 1`
                    right = mid - 1;
                }
            }

            // if we get here we didn't hit above return -1 so we didn't find target
            return -1;
        }
    }
}
