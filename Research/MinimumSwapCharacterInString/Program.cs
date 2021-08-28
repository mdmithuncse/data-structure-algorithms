using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumSwapCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "RGRGR";
            int n = s.Length;
            Console.WriteLine($"Minimum swap of string: {RedOrGreen(n, s)}");
        }

        static int RedOrGreen(int n, string s)
        {
            int count;
            Dictionary<string, int> pairs = new Dictionary<string, int>();

            for (int i = 0; i <= n - 1; i++)
            {
                if (pairs.ContainsKey(s[i].ToString()))
                {
                    pairs.TryGetValue(s[i].ToString(), out count);
                    count++;

                    pairs.Remove(s[i].ToString());
                    pairs.Add(s[i].ToString(), count);
                }

                else
                {
                    pairs.Add(s[i].ToString(), 1);
                }
            }
            
            return pairs.Aggregate((l, r) => l.Value < r.Value ? l : r).Value;
        }
    }
}
