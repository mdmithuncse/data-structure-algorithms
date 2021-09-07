using System;
using System.Collections.Generic;

namespace CheckIsogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "machine";
            Console.WriteLine($"Is isogram: {IsIsogram(s)}");
        }

        static bool IsIsogram(string s)
        {
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                }

                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
