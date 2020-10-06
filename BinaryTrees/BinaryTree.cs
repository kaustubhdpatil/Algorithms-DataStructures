using Models;
using System;
using System.Collections.Generic;

public class BinaryTree : IBinaryTree
{
    private TreeNode root;

    public TreeNode Root
    {
        get
        {
            return this.root;
        }
    }

    private void InOrderTraversal(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        this.InOrderTraversal(node.Left);
        Console.Write($"{node.Value} -> ");
        this.InOrderTraversal(node.Right);
    }

    public void PrintTreeInOrder()
    {
        this.InOrderTraversal(this.root);
        Console.WriteLine();
    }

    private void PreoderTraversal(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write($"{node.Value} -> ");
        this.PreoderTraversal(node.Left);
        this.PreoderTraversal(node.Right);
    }

    public void PrintTreePreOrder()
    {
        this.PreoderTraversal(this.root);
        Console.WriteLine();
    }

    public void PrintTreeInLevelOrder()
    {
        if (this.root == null)
        {
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(this.root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            Console.Write($"{node.Value} -> ");

            if (node.Left != null) 
            {
                queue.Enqueue(node.Left);
            }

            if (node.Right != null)
            {
                queue.Enqueue(node.Right);
            }
        }
    }

    public void LevelOrderInsertion(int value)
    {
        if (this.root == null)
        {
            this.root = new TreeNode(value);
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(this.root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();

            if (node.Left == null)
            {
                node.Left = new TreeNode(value);
                break;
            }
            else
            {
                queue.Enqueue(node.Left);
            }

            if (node.Right == null)
            {
                node.Right = new TreeNode(value);
                break;
            }
            else
            {
                queue.Enqueue(node.Right);
            }
        }
    }

    public void DeleteNode(int value)
    {
        throw new NotImplementedException();
    }
}