using System;

namespace TwoPointerSumTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] { 3, 5, 6, 7 };
            int target = 9;
            bool result = TwoSumTarget(input, target);
            Console.WriteLine($"The output is: { result }");
        }

        public static bool TwoSumTarget(int[] inputs, int target)
        {
            int sum;
            int pointer_one = 0;
            int pointer_two = inputs.Length - 1;
            bool result = false;

            while (pointer_one < pointer_two)
            {
                sum = inputs[pointer_one] + inputs[pointer_two];

                if (sum == target)
                {
                    result = true;

                    break;
                }

                else if (sum < target)
                {
                    pointer_one += 1;
                }

                else
                {
                    pointer_two -= 1;
                }
            }

            return result;
        }
    }
}
