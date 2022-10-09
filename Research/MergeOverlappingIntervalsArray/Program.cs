using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeOverlappingIntervalsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[][] input = new int[4][]
            //{
            //    new int[] { 8, 10 },
            //    new int[] { 15, 18 },
            //    new int[] { 1, 3 },
            //    new int[] { 2, 6 }
            //};

            //int[][] input = new int[2][]
            //{
            //    new int[] { 1, 4 },
            //    new int[] { 4, 5 }
            //};

            //int[][] input = new int[2][]
            //{
            //    new int[] { 1, 4 },
            //    new int[] { 5, 6 }
            //};

            //int[][] input = new int[1][]
            //{
            //    new int[] { 1, 4 }
            //};

            int[][] input = new int[][] { };

            int[][] result = Merge(input);

            for(int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < result[i].Length; j++)
                {
                    Console.WriteLine($"The element at [{i}, {j}]: {result[i][j]}");
                }
            }
        }

        static int[][] Merge(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            IList<int[]> merged = new List<int[]>();

            for (int i = 0; i < intervals.Length; i++)
            {
                // if the list of merged intervals is empty or if the interval does not overlap with the previous, simply append it
                if (!merged.Any() || merged.Last()[1] < intervals[i][0])
                {
                    merged.Add(new int[] { intervals[i][0], intervals[i][1] });
                }

                // otherwise there is overlap, so we merge the current and previous intervals
                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], intervals[i][1]);
                }
            }

            return merged.ToArray();
        }
    }
}
