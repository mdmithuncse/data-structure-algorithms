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
            int[,] ranges = new int[position.Length, 2];

            ranges = BuildArrayRange(position, arm);

            return false;
        }

        static int[,] BuildArrayRange(int[] position, int[] arm)
        {
            int[,] ranges = new int[position.Length, 2];

            for (int i = 0; i < position.Length; i++)
            {
                // Due to stop loop after one iteration
                for (int j = 0; j < 1; j++)
                {
                    ranges[i, j] = position[i] - arm[i];
                    ranges[i, j + 1] = position[i] + arm[i];
                }
            }

            return ranges;
        }
    }
}
