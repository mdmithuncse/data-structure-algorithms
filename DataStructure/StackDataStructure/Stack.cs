using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    public class Stack
    {
        private int[] items;
        private int top;
        private int capacity;

        // Create a stack
        public Stack(int size)
        {
            items = new int[size];
            capacity = size;
            top = -1;
        }

        // Add an item into stack
        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full.");
            }

            items[++top] = item;
            Console.WriteLine($"Added item: {item}");
        }

        // Remove an item from stack
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }

            return items[top--];
        }

        // Check stack is full
        public bool IsFull()
        {
            if (top == capacity - 1)
            {
                return true;
            }

            return false;
        }

        // Check stack is empty
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }

            return false;
        }

        // Return the size of the stack
        public int Size()
        {
            return top + 1;
        }

        // Print the elements of the stack
        public void PrintStack()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine($"Item : { items[i] }");
            }
        }
    }
}
