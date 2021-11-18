using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] tokens1 = new string[] { "2", "1", "+", "3", "*" };
            Console.WriteLine($"Output of {nameof(tokens1)} is: {EvalRPN(tokens1)}");

            string[] tokens2 = new string[] { "4", "13", "5", "/", "+" };
            Console.WriteLine($"Output of {nameof(tokens2)} is: {EvalRPN(tokens2)}");

            string[] tokens3 = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            Console.WriteLine($"Output of {nameof(tokens3)} is: {EvalRPN(tokens3)}");

            string[] tokens4 = new string[] { "4", "-2", "/", "2", "-3", "-", "-" };
            Console.WriteLine($"Output of {nameof(tokens4)} is: {EvalRPN(tokens4)}");
        }

        public static int EvalRPN(string[] tokens)
        {
            int i = 0;
            int val1, val2;

            Stack<int> stack = new Stack<int>();

            while (i < tokens.Length)
            {
                switch (tokens[i])
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        i++;

                        break;

                    case "-":
                        val1 = stack.Pop();
                        val2 = stack.Pop();
                        stack.Push(val2 - val1);
                        i++;

                        break;

                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        i++;

                        break;

                    case "/":
                        val1 = stack.Pop();
                        val2 = stack.Pop();
                        stack.Push(val2 / val1);
                        i++;

                        break;

                    default:
                        stack.Push(int.Parse(tokens[i]));
                        i++;

                        break;
                }
            }

            return stack.Pop();
        }
    }
}
