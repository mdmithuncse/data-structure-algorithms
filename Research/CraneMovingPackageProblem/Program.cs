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
            int[] position = { 3, 6, 10 };
            int[] arm = { 3, 2, 1 };
            int source = 7;
            int destination = 0;

            Console.WriteLine($"Result is: {IsMovable(position, arm, source, destination)}");
        }

        static bool IsMovable(int[] position, int[] arm, int source, int destination)
        {
            int[] ranges = BuildArrayRange(position, arm);

            if (IsOverlapped(ranges))
            {
                if ((source >= ranges[0] || destination  >= ranges[0]) && 
                    (source <= ranges[ranges.Length - 1] || destination <= ranges[ranges.Length - 1]))
                {
                    return true;
                }
            }

            else
            {
                // Todo:
            }

            return false;
        }

        static bool IsOverlapped(int[] input)
        {
            bool result = false;

            for (int i = 0; i < input.Length; i+=2)
            {
                if (input[i + 1] >= input[i + 2])
                {
                    result = true;

                    continue;
                }

                else
                {
                    result = false;

                    break;
                }
            }

            return result;
        }

        static int[] BuildArrayRange(int[] position, int[] arm)
        {
            int j = 0;
            int[] ranges = new int[position.Length * 2];

            for (int i = 0; i < ranges.Length;)
            {
                while (j < position.Length)
                {
                    ranges[i] = position[j] - arm[j];
                    ranges[i + 1] = position[j] + arm[j];
                    j++;

                    break;
                }

                i+=2;
            }

            return ranges;
        }
    }
}
