using Models;
using System;

namespace Search
{
    public class BinarySearchTree : ISearchable, ITree
    {
        private Node _root;

        public BinarySearchTree(Node rootNode)
        {
            this._root = rootNode;
        }

        public void Add(Node newNode)
        {
            Node currentNode = this._root;

            while (true)
            {
                if (currentNode.Value >= newNode.Value)
                {
                    if (currentNode.LeftChild == null) 
                    {
                        currentNode.LeftChild = newNode;
                        break;
                    }

                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value < newNode.Value)
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = newNode;
                        break;
                    }

                    currentNode = currentNode.RightChild;
                }
            }
        }

        public void PrintInOrder()
        {
            this.PrintInOrder(this._root);
        }

        private void PrintInOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            // Print left
            this.PrintInOrder(node.LeftChild);
            // print root
            Console.WriteLine($"{node.Value} ");
            // print right
            this.PrintInOrder(node.RightChild);
        }

        public int Search(int itemToSearch)
        {
            return this.Search(this._root, itemToSearch);
        }

        public int Search(Node rootNode, int itemToSearch)
        {
            Node currentNode = rootNode;

            while (currentNode != null)
            {
                if (currentNode.Value == itemToSearch)
                {
                    return currentNode.Value;
                }
                else if (currentNode.Value > itemToSearch)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value < itemToSearch)
                {
                    currentNode = currentNode.RightChild;
                }
            }

            return -1;
        }
    }
}