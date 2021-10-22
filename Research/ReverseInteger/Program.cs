using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int input = 321;
            Console.WriteLine($"Output is: {Reverse(input)}");
        }

        public int Reverse(int x)
        {
            int rev = 0;

            while (x > 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }

            return rev >= int.MaxValue || rev <= int.MinValue ? 0 : rev;
        }
    }
}
