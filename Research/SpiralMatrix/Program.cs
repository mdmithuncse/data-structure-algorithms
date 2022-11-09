using System;
using System.Collections.Generic;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] matrix = new int[][] 
            {
                new int[] { 1, 2, 3},
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            IList<int> result = SpiralOrder(matrix);
            Console.Write($"The result is: ");
            for(int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]}, ");
            }
        }

        static IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return new List<int>();

            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;
            int size = matrix.Length * matrix[0].Length;
            IList<int> items = new List<int>();

            while(items.Count < size)
            {
                // Traverse from left to right top row only
                for(int i = left; i <= right && items.Count < size; i++)
                {
                    items.Add(matrix[top][i]);
                }
                top++;

                // Traverse from top to bottom right column only
                for(int i = top; i <= bottom && items.Count < size; i++)
                {
                    items.Add(matrix[i][right]);
                }
                right--;

                // Traverse from right to left bottom row only
                for(int i = right; i >= left && items.Count < size; i--)
                {
                    items.Add(matrix[bottom][i]);
                }
                bottom--;

                // Traverse from bottom to top left column only
                for(int i = bottom; i >= top && items.Count < size; i--)
                {
                    items.Add(matrix[i][left]);
                }

                left++;
            }

            return items;
        }
    }
}
