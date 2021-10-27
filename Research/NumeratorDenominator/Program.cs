using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatingDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numerator = 8;
            int denominator = 3;
            Console.WriteLine($"Result of division for {nameof(numerator)} {(numerator)} and {nameof(denominator)} {(denominator)} is : { RepeatingDecimal(numerator, denominator) }");

            numerator = 1;
            denominator = 2;
            Console.WriteLine($"Result of division for {nameof(numerator)} {(numerator)} and {nameof(denominator)} {(denominator)} is : { RepeatingDecimal(numerator, denominator) }");

            numerator = 2;
            denominator = 1;
            Console.WriteLine($"Result of division for {nameof(numerator)} {(numerator)} and {nameof(denominator)} {(denominator)} is : { RepeatingDecimal(numerator, denominator) }");

            numerator = 2;
            denominator = 3;
            Console.WriteLine($"Result of division for {nameof(numerator)} {(numerator)} and {nameof(denominator)} {(denominator)} is : { RepeatingDecimal(numerator, denominator) }");
        }

        static string RepeatingDecimal(int numerator, int denominator)
        {
            if (numerator == 0) return "0";
            
            StringBuilder sb = new StringBuilder();

            if ((numerator < 0 && denominator > 0) ||
                (numerator > 0 && denominator < 0))
            {
                sb.Append("-");
            }

            long divisor = Math.Abs((long)numerator);
            long dividend = Math.Abs((long)denominator);
            long remainder = divisor % dividend;
            long quotient = divisor / dividend;
            sb.Append(quotient);

            if (remainder == 0)
            {
                return sb.ToString();
            }

            sb.Append(".");
            Dictionary<long, int> map = new Dictionary<long, int>();

            while (remainder != 0)
            {
                if (map.ContainsKey(remainder))
                {
                    int length = map.GetValueOrDefault(remainder);
                    sb.Insert(length, "(");
                    sb.Append(")");

                    break;
                }

                map.Add(remainder, sb.Length);
                remainder *= 10;
                quotient = remainder / dividend;
                sb.Append(quotient);
                remainder %= dividend;
            }

            return sb.ToString();
        }
    }
}
