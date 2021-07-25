using System;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to stack data structure example");

            Stack stack = new Stack(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            stack.PrintStack();

            stack.Pop();

            stack.PrintStack();

            stack.Push(11);

            stack.PrintStack();
        }
    }
}
