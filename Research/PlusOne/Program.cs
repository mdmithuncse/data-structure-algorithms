using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // digits = [1,2,3]
            // digits = [4,3,2,1]
            // digits = [0]
            // digits = [9]
            int[] input = new int[] { 1, 2, 3 };
            Console.WriteLine($"Output is: ");
            foreach(int i in PlusOne(input))
            {
                Console.WriteLine(i);
            }
        }

        public static int[] PlusOne(int[] digits)
        {
            int carry = 0;

            // Add 1 to the last digit and find carry
            digits[digits.Length - 1] += 1;
            carry = digits[digits.Length - 1] / 10;
            digits[digits.Length - 1] = digits[digits.Length - 1] % 10;

            // Traverse from the second last digit
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                if (carry == 1)
                {
                    digits[i] += 1;
                    carry = digits[i] / 10;
                    digits[i] = digits[i] % 10;
                }
            }

            // If the carry is 1, we need to add 1 in the beginning of the array
            if (carry == 1)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = carry;
            }

            return digits;
        }
    }
}
