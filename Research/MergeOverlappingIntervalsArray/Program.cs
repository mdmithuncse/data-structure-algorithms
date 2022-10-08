using System;
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
        }

        static int[][] Merge(int[][] intervals)
        {
            if (intervals == null ||
                intervals.Length == 0 || 
                intervals.Length == 1)
            {
                return intervals;
            }

            intervals = intervals.OrderBy(x => x[0]).ToArray();
            int start = intervals[0][0];
            int end = intervals[0][1];
        }
    }
}
