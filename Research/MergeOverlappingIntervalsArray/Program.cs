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
            // intervals = [[1,3],[2,6],[8,10],[15,18]]
            // intervals = [[1,4],[4,5]]
            int[][] input = new int[4][]
            {
                new int[] { 8, 10 },
                new int[] { 15, 18 },
                new int[] { 1, 3 },
                new int[] { 2, 6 }
            };

            //int[][] input = new int[2][]
            //{
            //    new int[] { 1, 4 },
            //    new int[] { 4, 5 }
            //};

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
            if (intervals == null || intervals.Length == 0)
                return new int[][] { };

            intervals = intervals.OrderBy(x => x[0]).ToArray();
            int start = intervals[0][0];
            int end = intervals[0][1];

            IList<int[]> merged = new List<int[]>();

            for(int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > end)
                {
                    start = intervals[i][0];
                    end = intervals[i][1];

                    merged.Add(new int[] { start, end });
                }

                else
                {
                    end = Math.Max(end, intervals[i][1]);

                    merged.Add(new int[] { start, end });
                }
            }

            return merged.ToArray();
        }
    }
}
