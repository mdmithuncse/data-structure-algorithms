using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to stack data structure example");

            Stack stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.PrintStack();

            stack.Pop();

            stack.PrintStack();

            stack.Push(6);

            stack.PrintStack();
        }
    }
}
