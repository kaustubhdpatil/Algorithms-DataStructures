using System;

namespace StackDs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a stack implementation example");
            Console.WriteLine("Generating a sample stack...");
            IStack stack = new StackDataStructure();
            Console.WriteLine($"Stack IsEmpty? {stack.IsEmpty()}");

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i + 1);
                Console.WriteLine($"Pushed {stack.Top} on the stack");
            }

            Console.WriteLine($"Peek at the top of the stack: {stack.Peek()}");
            Console.WriteLine("Pop until the stack is empty...");

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
