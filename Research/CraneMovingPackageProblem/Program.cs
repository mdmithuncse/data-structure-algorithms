using System;
using System.Collections.Generic;
using System.Linq;

namespace CraneMovingPackageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] position = { 3, 6, 10 };
            //int[] arm = { 3, 2, 1 };
            //int source = 7;
            //int destination = 0;

            //int[] position = { 5, 1 };
            //int[] arm = { 2, 1 };
            //int source = 3;
            //int destination = 6;

            //int[] position = { 5, 1 };
            //int[] arm = { 2, 1 };
            //int source = 2;
            //int destination = 6;

            int[] position = { 10, 4, 7 };
            int[] arm = { 1, 4, 2 };
            int source = 11;
            int destination = 1;

            Console.WriteLine($"Result is: {IsMovable(position, arm, source, destination)}");
        }

        static bool IsMovable(int[] position, int[] arm, int source, int destination)
        {
            IList<int[]> ranges = BuildRange(position, arm);
            IList<int[]> merged = MergeRange(ranges);

            for(int i = 0; i < merged.Count; i++)
            {
                if (destination > source)
                {
                    if (source >= merged[i][0] && destination <= merged[i][1])
                    {
                        return true;
                    }
                }

                else if (source > destination)
                {
                    if (source <= merged[i][1] && destination >= merged[i][0])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static IList<int[]> BuildRange(int[] position, int[] arm)
        {
            IList<int[]> ranges = new List<int[]>();

            for(int i = 0; i < position.Length; i++)
            {
                ranges.Add(new int[] { position[i] - arm[i], position[i] + arm[i] });
            }

            return ranges;
        }

        static IList<int[]> MergeRange(IList<int[]> ranges)
        {
            ranges = ranges.OrderBy(x => x[0]).ToList();

            IList<int[]> merged = new List<int[]>();

            for (int i = 0; i < ranges.Count; i++)
            {
                if (!merged.Any() || merged.Last()[1] < ranges[i][0])
                {
                    merged.Add(new int[] { ranges[i][0], ranges[i][1] });
                }

                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], ranges[i][1]);
                }
            }

            return merged;
        }
    }
}
