using Models;
using System;

namespace Search
{
    class Program
    {
        static void BuildTree(BinarySearchTree bst)
        {
            bool addNode = true;

            while (addNode)
            {
                Console.WriteLine("Enter the value for the node to be added");

                if (int.TryParse(Console.ReadLine(), out int nodeValue))
                {
                    bst.Add(new Node(nodeValue));
                    Console.WriteLine("Enter 1 to add another node, else enter 2");
                    int.TryParse(Console.ReadLine(), out int contine);
                    addNode = contine == 1;
                }
                else
                {
                    Console.WriteLine("Invalid integer value entered. Try again.");
                }
            }
        }

        static void Search(BinarySearchTree bst)
        {
            bool continueSearching = true;

            while (continueSearching)
            {
                Console.WriteLine("Enter the value to search");
                bool found = false;
                int value = -1;

                if (int.TryParse(Console.ReadLine(), out int searchData))
                {
                    value = bst.Search(searchData);
                    found = value != -1;
                }

                if (found)
                {
                    Console.WriteLine($"{value} found in the tree.");
                }
                else
                {
                    Console.WriteLine("Item cannot be found");
                }

                Console.WriteLine("Enter 1 to search another item");
                int.TryParse(Console.ReadLine(), out int searchAgain);
                continueSearching = searchAgain == 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Empty.PadLeft(25, '-'));
            Console.WriteLine("Welcome to Binary Search Tree");
            Console.WriteLine(string.Empty.PadLeft(25, '-'));
            Console.WriteLine("Step 1. Build the tree to search on");
            Console.WriteLine("Enter the root node value");

            if (int.TryParse(Console.ReadLine(), out int rootNodeValue))
            {
                BinarySearchTree bst = new BinarySearchTree(new Node(rootNodeValue));

                // Build the tree
                BuildTree(bst);

                Console.WriteLine(string.Empty.PadLeft(25, '-'));
                // Print in-order tree
                bst.PrintInOrder();

                Console.WriteLine(string.Empty.PadLeft(25, '-'));
                // Enter the value to search
                Search(bst);
            }
            else
            {
                Console.WriteLine("Invalid integer value entered");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
