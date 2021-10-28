using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "()[]{}";
            Console.WriteLine($"Balanced Parentheses: {IsValid(input)}");
        }

        private static bool IsMatchPair(char ch1, char ch2)
        {
            if (ch1 == '(' && ch2 == ')')
            {
                return true;
            }
            else if (ch1 == '{' && ch2 == '}')
            {
                return true;
            }
            else if (ch1 == '[' && ch2 == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {                
                if (input[i] == '(' ||
                    input[i] == '{' ||
                    input[i] == '[')
                {
                    stack.Push(input[i]);
                }

                else if (input[i] == ')' ||
                         input[i] == '}' ||
                         input[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    else if (!IsMatchPair(stack.Pop(), input[i]))
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
