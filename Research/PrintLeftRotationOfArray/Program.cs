using System;

namespace PrintLeftRotationOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1, 3, 5, 7, 9 };
            int n = arr.Length;

            int k = 2;

            // Function Call
            LeftRotate(arr, n, k);

            k = 3;

            // Function Call
            LeftRotate(arr, n, k);

            k = 4;

            // Function Call
            LeftRotate(arr, n, k);
        }

        // Function to leftRotate
        // array multiple times
        static void LeftRotate(int[] arr, int n, int k)
        {
            // To get the starting
            // point of rotated array
            int mod = k % n;

            // Prints the rotated array
            // from start position
            for (int i = 0; i < n; ++i)
            {
                int index = (i + mod) % n;
                int value = arr[index];
                Console.Write(arr[(i + mod) % n] + " ");
            }

            Console.WriteLine();
        }
    }
}
