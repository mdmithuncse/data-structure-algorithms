using System;

namespace DuplicateZerosArray
{
    class Program
    {
        /*
         Input: arr = [1,0,2,3,0,4,5,0]
         Output: [1,0,0,2,3,0,0,4]
         Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]

         Input: arr = [1,2,3]
         Output: [1,2,3]
         Explanation: After calling your function, the input array is modified to: [1,2,3]
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            DuplicateZeros(arr);
        }

        static void DuplicateZeros(int[] arr)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                if(arr[i] == 0)
                {
                    for(int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }

                    i++; // we don't want to traverse over the duplicate zero
                }
            }
        }
    }
}
