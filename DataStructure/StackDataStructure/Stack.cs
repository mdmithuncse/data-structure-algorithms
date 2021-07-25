using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    public class Stack
    {
        private int[] array;
        private int top;
        private int capacity;

        // Create a stack
        public Stack(int size)
        {
            array = new int[size];
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

            Console.WriteLine($"Adding item: {item}");
            array[++top] = item;
        }

        // Remove an item from stack
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }

            return array[top--];
        }

        // Check stack is full
        public bool IsFull()
        {
            return top == capacity - 1;
        }

        // Check stack is empty
        public bool IsEmpty()
        {
            return top == -1;
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
                Console.WriteLine($"Item : {array[i]}");
            }
        }
    }
}
