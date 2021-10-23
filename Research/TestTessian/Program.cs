using System;
using System.Collections.Generic;

namespace TestTessian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string expression = "+ 1 56";
            string variables = string.Empty;

            Console.WriteLine($"Output is: {CalculateExpression(expression, variables)}");
        }

        private static bool IsNumber(char c)
        {
            if (c >= 48 && c <= 57)
            {
                return true;
            }

            return false;
        }

        private static bool IsSpace(char c)
        {
            if (c == 32)
            {
                return true;
            }

            return false;
        }

        private static bool IsCharacter(char c)
        {
            if ((c >= 97 && c <= 122) || (c >= 65 && c <= 90))
            {
                return true;
            }

            return false;
        }

        private static bool ValidateExpression(string expression)
        {
            bool result = true;

            if (string.IsNullOrEmpty(expression))
            {
                result = false;

                return result;
            }

            for (int i = 0; i < expression.Length; i++)
            {
                if (Convert.ToInt32(expression[i]) < 0)
                {
                    result = false;

                    break;
                }
            }

            return result;
        }

        public static int CalculateExpression(string expression, string variables)
        {
            if (!ValidateExpression(expression))
            {
                throw new Exception();
            }

            Stack<int> stack = new Stack<int>();

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                if (IsSpace(expression[i]))
                {
                    continue;
                }

                if (IsNumber(expression[i]))
                {
                    stack.Push((int)(expression[i] - 48));
                }

                if (IsCharacter(expression[i]))
                {
                    variables.Contains(expression[i]);
                }

                else
                {
                    int num1 = stack.Peek();
                    stack.Pop();

                    int num2 = stack.Peek();
                    stack.Pop();

                    switch (expression[i])
                    {
                        case '+':
                            stack.Push(num1 + num2);

                            break;

                        case '-':
                            stack.Push(num1 - num2);

                            break;

                        case '*':
                            stack.Push(num1 * num2);

                            break;

                        case '/':
                            stack.Push(num1 / num2);

                            break;
                    }
                }
            }

            return stack.Peek();
        }

        //private static bool CheckArithmeticOperators(string expression)
        //{
        //    bool result = false;

        //    HashSet<string> arithmeticOperators = new HashSet<string>();
        //    arithmeticOperators.Add("+");
        //    arithmeticOperators.Add("-");
        //    arithmeticOperators.Add("*");
        //    arithmeticOperators.Add("/");

        //    for (int i = 0; i < expression.Length; i++)
        //    {
        //        if (arithmeticOperators.Contains(expression[i]))
        //        {
        //            result = true;

        //            break;
        //        }
        //    }

        //    return result;
        //}
    }
}
