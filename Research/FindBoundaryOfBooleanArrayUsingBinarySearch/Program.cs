using System;

namespace FindBoundaryOfBooleanArrayUsingBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Extended binary search: { FindBoundary(new bool[] { false, false, true, true, true }) }");
        }

        static int FindBoundary(bool[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            int boundaryIndex = -1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid])
                {
                    boundaryIndex = mid;
                    right = mid - 1;
                }

                else
                {
                    left = mid + 1;
                }
            }

            return boundaryIndex;
        }
    }
}
