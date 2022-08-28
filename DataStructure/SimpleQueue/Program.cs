using System;

namespace SimpleQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to simple queue data structure example");

            SimpleQueue queue = new SimpleQueue(5);

            // Dequeue is not possible on empty queue
            queue.Dequeue();

            // Enqueue five elements
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Sixth element can't be added because the queue is full
            queue.Enqueue(6);

            queue.PrintQueue();

            // Dequeue first element
            queue.Dequeue();

            // Now we have just four elements
            queue.PrintQueue();
        }
    }
}
