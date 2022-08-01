using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Linear search : " + LinearSearch(new int[] { 1, 3, 5, 7, 8 }, 5));
            Console.WriteLine("Linear search : " + LinearSearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 0));
            Console.WriteLine("Linear search : " + LinearSearch(new int[] { 2, 8, 89, 120, 1000 }, 120));
        }

        static int LinearSearch(int[] arr, int target)
        {
            // Loop through each element in the array
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                // If the target element found, then return the index of the element
                if (arr[i] == target)
                {
                    return i;
                }
            }
            
            // If the target element not found in the array, then return -1 as the element isn't found in the array
            return -1;
        }
    }
}
