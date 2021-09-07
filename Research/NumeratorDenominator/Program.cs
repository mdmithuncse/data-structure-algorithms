using System;

namespace NumeratorDenominator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"Result of division: {Repeat(8, 3)}");

        }

        static string Repeat(int input1, int input2)
        {
            decimal result;

            if (input1 > input2)
            {
                result = CalculateResult(input1, input2);
            }

            else
            {
                result = CalculateResult(input2, input1);
            }

            if (result.ToString().Contains('.'))
            {
                return GenerateOutput(result.ToString());
            }

            return result.ToString();
        }
         
        static string GenerateOutput(string input)
        {
            string output;
            string[] tempArray = input.Split('.');
            string temp = tempArray[1];
            output = $"{tempArray[0]}.(";
            
            for (int i = 0; i < temp.Length; i++)
            {
                if (!output.Contains(temp[i]))
                {
                    output += temp[i];
                }
            }

            output += ")";

            return output;
        }

        static decimal CalculateResult(int numerator, int denominator)
        {
            return (decimal) numerator / denominator;
        }
    }
}
