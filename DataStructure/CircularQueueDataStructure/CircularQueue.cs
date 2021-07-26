using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueDataStructure
{
    public class CircularQueue
    {
        private int[] items;
        private int capacity;
        private int front;
        private int rear;

        // Create a circualr queue
        public CircularQueue(int size)
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
                {
                    front = 0;
                }

                rear = (rear + 1) % capacity;
                items[rear] = item;

                Console.WriteLine($"Added item: {item}");
            }
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

            else
            {
                item = items[front];

                // Queue has only one element, so we reset the queue after delete the item
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }

                else
                {
                    front = (front + 1) % capacity;
                }
            }

            return item;
        }

        // Check queue is empty
        public bool IsEmpty()
        {
            if (front == -1 && rear == -1)
            {
                return true;
            }

            return false;
        }

        // Check queue is full
        public bool IsFull()
        {
            if (front == 0 && rear == capacity - 1)
            {
                return true;
            }

            if (front == rear + 1)
            {
                return true;
            }

            return false;
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

            for (int i = front; i != rear; i = (i + 1) % capacity)
            {
                Console.WriteLine($"{ items[i] }  ");
                Console.WriteLine($"{ items[i] }");
            }

            Console.WriteLine($"Rear { rear }");
        }
    }
}
