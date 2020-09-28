using Models;
using System;

public class DoublyLinkedListDs : ILinkedList
{
    // private variables
    private int lengthOfLinkedList = 0;
    private Node headOfLinkedList = null;

    public int Length 
    {
        get
        {
            return this.lengthOfLinkedList;
        }
    }

    public Node Head
    {
        get
        {
            return this.headOfLinkedList;
        }
    }

    public void InsertAtTheEnd(int valueToInsert)
    {
        if (this.headOfLinkedList == null)
        {
            this.headOfLinkedList = new Node(valueToInsert);
            this.lengthOfLinkedList++;
            return;
        }

        Node node = this.headOfLinkedList;

        while (node.NextNode != null)
        {
            node = node.NextNode;
        }

        Node newNode = new Node(valueToInsert, node);
        node.NextNode = newNode;
        this.lengthOfLinkedList++;
    }

    public void Print()
    {
        if (this.headOfLinkedList == null)
        {
            Console.WriteLine("Linked list is empty!");
        }

        Node node = this.headOfLinkedList;

        while (node != null)
        {
            Console.Write($"{node.Value} -> ");
            node = node.NextNode;
        }

        Console.Write("null");
        Console.WriteLine();
    }

    public void Delete(int valueToDelete)
    {
        if (this.headOfLinkedList == null)
        {
            throw new Exception($"{valueToDelete} cannot be deleted from an empty linked list.");
        }

        if (this.headOfLinkedList.Value == valueToDelete)
        {
            Node oldNode = this.headOfLinkedList;
            this.headOfLinkedList = oldNode.NextNode;

            if (this.headOfLinkedList != null)
            {
                this.headOfLinkedList.PreviousNode = null;
            }
            
            oldNode = null;
            this.lengthOfLinkedList--;
            return;
        }

        Node node = this.headOfLinkedList;

        while (node != null)
        {
            if (node.Value == valueToDelete)
            {
                if (node.NextNode != null)
                {
                    node.NextNode.PreviousNode = node.PreviousNode;
                }

                if (node.PreviousNode != null)
                {
                    node.PreviousNode.NextNode = node.NextNode;
                }
                
                node.NextNode = null;
                node.PreviousNode = null;
                node = null;
                this.lengthOfLinkedList--;
                return;
            }

            node = node.NextNode;
        }

        throw new Exception($"{valueToDelete} not found in the linked list.");
    }

    public bool Contains(int valueToSearch)
    {
        if (this.headOfLinkedList != null)
        {
            Node node = this.headOfLinkedList;

            while (node != null)
            {
                if (node.Value == valueToSearch)
                {
                    return true;
                }

                node = node.NextNode;
            }
        }

        return false;
    }

    public bool IsEmpty()
    {
        return this.headOfLinkedList == null && this.lengthOfLinkedList == 0;
    }
}