using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDataStructure
{
    public class Queue
    {
        private int[] items;
        private int capacity;
        private int front;
        private int rear;

        // Create a queue
        public Queue(int size)
        {
            items = new int[size];
            front = -1;
            rear = -1;
            capacity = size;
        }       

        // Add an item into queue
        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }

            else
            {
                if (front == -1)
                    front = 0;

                rear++;
                items[rear] = item;
            }
            
            Console.WriteLine($"Added item: {item}");
        }

        // Remove an item from queue
        public int Dequeue()
        {
            int item;

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                item = -1;
                return item;
            }

            item = items[front];

            // Queue has only one element, so we reset the queue after delete the item
            if (front >= rear)
            {
                front = -1;
                rear = -1;
            }

            else
            {
                front++;
            }

            Console.WriteLine($"Deleted item: {item}");

            return item;
        }

        // Check queue is empty
        public bool IsEmpty()
        {
            return front == -1 ? true : false;
        }

        // Check queue is full
        public bool IsFull()
        {
            return (front == 0 && rear == capacity - 1) ? true : false;
        }

        // Return the size of the queue
        public int Size()
        {
            return capacity;
        }

        // Print the elements of the queue
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }

            else
            {
                Console.WriteLine($"Front index: { front }");
                Console.WriteLine("Items -> ");

                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine($"{ items[i] }  ");
                }

                Console.WriteLine($"Rear index: { rear }");
            }
        }
    }
}
