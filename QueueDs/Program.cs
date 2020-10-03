using System;

namespace QueueDs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Queue implementation example");
            Console.WriteLine("Generating a sample queue...");
            IQueue queue = new QueueDataStructure();
            Console.WriteLine($"Queue IsEmpty? {queue.IsEmpty()}");

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i + 1);
                Console.WriteLine($"Enqueueing {i+1} in the queue completed.");
            }

            Console.WriteLine($"Peek at the top of the queue: {queue.Peek()}");
            Console.WriteLine("Dequeue until the queue is empty...");

            while (!queue.IsEmpty())
            {
                Console.WriteLine($"Dequeueing {queue.Dequeue()} from the queue completed");
            }
        }
    }
}
