﻿using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                    continue;
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                    continue;
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
