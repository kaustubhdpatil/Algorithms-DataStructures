using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void DeleteAndPrint(int value, ILinkedList linkedListDs)
        {
            Console.WriteLine($"Deleting {value}...");
            linkedListDs.Delete(value);
            linkedListDs.Print();
            Console.WriteLine($"Deleted {value} successfully");
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to a linked list implementation example");
                Console.WriteLine("Generating a sample linked list...");
                ILinkedList linkedListDs = new SinglyLinkedListDs();

                for (int i = 0; i < 10; i++)
                {
                    linkedListDs.InsertAtTheEnd(i + 1);
                }

                Console.WriteLine("Linked list generation complete!");
                Console.WriteLine("Printing linked list..");
                Console.WriteLine("".PadLeft(20,'-'));
                linkedListDs.Print();

                Console.WriteLine("".PadLeft(20,'-'));
                Console.WriteLine("Enter the value to search:");

                if (!int.TryParse(Console.ReadLine(), out int valueToSearch))
                {
                    Console.WriteLine("Invalid integer value entered");
                }
                else
                {
                    string result = linkedListDs.Contains(valueToSearch) ? "contains" : "does not contain";
                    Console.WriteLine($"Linked list {result} the value {valueToSearch}");
                }
                Console.WriteLine("".PadLeft(20,'-'));
                for (int i = 1; i < 11; i++)
                {
                    DeleteAndPrint(i, linkedListDs);
                }

                DeleteAndPrint(100, linkedListDs);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Demo of a linked list implementation completed.");
            }
        }
    }
}
