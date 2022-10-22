using System;

namespace ReplaceElementsWithGreatestElementOnRightSide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 17, 18, 5, 4, 6, 1};
            Console.WriteLine($"The output is: { ReplaceElements(arr) }");
        }

        static int[] ReplaceElements(int[] arr)
        {
            int max = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = max;

                if (temp > max)
                    max = temp;
            }

            return arr;
        }
    }
}
