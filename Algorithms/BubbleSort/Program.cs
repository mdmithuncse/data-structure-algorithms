using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[5] { 78, 55, 45, 98, 13 };
            //int[] input = new int[3] { 1, 3, 2 };
            Console.WriteLine("Bubble sorted array:");
            foreach (var item in BubbleSort(input))
                Console.Write($"{item} --> ");
        }

        private static int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return input;
        }
    }
}
