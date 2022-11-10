using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numRows = 5;
            Generate(numRows);
        }

        static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> pascalList = new List<IList<int>>();
            pascalList.Add(new List<int>() { 1 });

            if (numRows == 1)
                return pascalList;

            pascalList.Add(new List<int>() { 1, 1 });

            if (numRows == 2)
                return pascalList;

            for(int i = 2; i < numRows; i++)
            {
                IList<int> items = new List<int>();

                for(int j = 0; j <= i; j++)
                {
                    if (j == 0)
                        items.Add(1);

                    else if(j > 0 && j < i)
                    {
                        items.Add(pascalList[i - 1][j - 1] + pascalList[i - 1][j]);
                    }

                    else
                    {
                        items.Add(1);
                    }
                }

                pascalList.Add(items);
            }

            return pascalList;
        }
    }
}
