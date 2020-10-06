using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the implementation of Binary Tree.");
            Console.WriteLine("Generating the tree with node values from 1-16...");
            IBinaryTree binaryTree = new BinaryTree();

            for (int i = 1; i < 16; i++)
            {
                binaryTree.LevelOrderInsertion(i);
            }

            Console.WriteLine("Printing the binary tree in order...");
            binaryTree.PrintTreeInOrder();
            
            Console.WriteLine("Printing the binary tree in pre order manner...");
            binaryTree.PrintTreePreOrder();
            
            Console.WriteLine("Printing the binary tree in level order manner...");
            binaryTree.PrintTreeInLevelOrder();
        }
    }
}
