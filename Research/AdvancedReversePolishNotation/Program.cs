using System;
using System.Collections.Generic;

namespace AdvancedReversePolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] tokens1 = new string[] { "2", "1", "+", "3", "*" };

            Console.WriteLine($"Is valid {nameof(tokens1)} polish notation expression: {IsValidRPN(tokens1)}");
            Console.WriteLine($"Output of {nameof(tokens1)} is: {EvalRPN(tokens1)}");

            string[] tokens2 = new string[] { "2", " ", "3", " ", "+", "-" };

            Console.WriteLine($"Is valid {nameof(tokens2)} polish notation expression: {IsValidRPN(tokens2)}");
            Console.WriteLine($"Output of {nameof(tokens2)} is: {EvalRPN(tokens2)}");

            string[] tokens3 = new string[] { "4", "13", "5", "/", "+" };
            Console.WriteLine($"Is valid {nameof(tokens3)} polish notation expression: {IsValidRPN(tokens3)}");
            Console.WriteLine($"Output of {nameof(tokens3)} is: {EvalRPN(tokens3)}");

            string[] tokens4 = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            Console.WriteLine($"Is valid {nameof(tokens4)} polish notation expression: {IsValidRPN(tokens4)}");
            Console.WriteLine($"Output of {nameof(tokens4)} is: {EvalRPN(tokens4)}");

            string[] tokens5 = new string[] { "4", "-10", "/", "-50", "3", "-", "-" };
            Console.WriteLine($"Is valid {nameof(tokens5)} polish notation expression: {IsValidRPN(tokens5)}");
            Console.WriteLine($"Output of {nameof(tokens5)} is: {EvalRPN(tokens5)}");
        }

        public static IDictionary<string, int> ExecuteHashMap(IDictionary<string, int> map, string key, int value)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return default;
            }

            if (!map.ContainsKey(key))
            {
                value++;

                map.Add(key, value);
                return map;
            }

            value = map[key];
            value++;

            map.Remove(key);
            map.Add(key, value);

            return map;
        }

        public static bool IsValidRPN(string[] tokens)
        {
            int operandCount = 0;
            int operatorCount = 0;
            int separatorCount = 0;
            
            IDictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                // Ascii value for 0 to 9
                if (Convert.ToChar(tokens[i]) >= 48 && Convert.ToChar(tokens[i]) <= 57)
                {
                    map = ExecuteHashMap(map, "Operand", operandCount);

                    continue;
                }

                // Ascii value for mathematical operator
                if (Convert.ToChar(tokens[i]) == 42 || Convert.ToChar(tokens[i]) == 43 || Convert.ToChar(tokens[i]) == 45 || Convert.ToChar(tokens[i]) == 47)
                {
                    map = ExecuteHashMap(map, "Operator", operatorCount);

                    continue;
                }

                // Ascii value for space
                if (Convert.ToChar(tokens[i]) == 32)
                {
                    map = ExecuteHashMap(map, "Separator", separatorCount);

                    continue;
                }
            }

            if (map["Operand"] == map["Separator"] && map["Operator"] * 2 == map["Operand"])
            {
                return true;
            }

            return false;
        }

        public static int EvalRPN(string[] tokens)
        {
            int val1, val2;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                switch (tokens[i])
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());

                        break;

                    case "-":
                        val1 = stack.Pop();
                        val2 = stack.Pop();
                        stack.Push(val2 - val1);

                        break;

                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());

                        break;

                    case "/":
                        val1 = stack.Pop();
                        val2 = stack.Pop();
                        stack.Push(val2 / val1);

                        break;

                    default:
                        stack.Push(int.Parse(tokens[i]));

                        break;
                }
            }

            return stack.Pop();
        }
    }
}
