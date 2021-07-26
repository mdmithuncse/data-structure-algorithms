using System;

namespace CircularQueueDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to circular queue data structure example");

            CircularQueue circularQueue = new CircularQueue(5);


            // Fails because front = -1
            circularQueue.Dequeue();

            // Success to enqueue
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(2);
            circularQueue.Enqueue(3);
            circularQueue.Enqueue(4);
            circularQueue.Enqueue(5);

            // Fails to enqueue because front == 0 && rear == SIZE - 1
            circularQueue.Enqueue(6);

            circularQueue.PrintQueue();

            int item = circularQueue.Dequeue();

            if (item != -1)
            {
                Console.WriteLine("Deleted item: " + item);
            }

            circularQueue.PrintQueue();

            circularQueue.Enqueue(7);

            circularQueue.PrintQueue();

            // Fails to enqueue because front == rear + 1
            circularQueue.Enqueue(8);
        }
    }
}
