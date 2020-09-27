using Model;
using System;

public class SinglyLinkedListDs : ILinkedList
{
    private Node head = null;
    private int length = 0;

    // getter property to hold the head
    public Node Head
    {
        get
        {
            return this.head;
        }
    }

    // getter property to hold length of linked list
    public int Length
    {
        get
        {
            return this.length;
        }
    }

    // function to add new node at the end
    public void InsertAtTheEnd(int valueToInsert)
    {
        if (this.head == null)
        {
            this.head = new Node(valueToInsert);
            this.length++;
            return;
        }

        Node nodeToInsertAfter = this.head;

        while (nodeToInsertAfter.Next != null) 
        {
            nodeToInsertAfter = nodeToInsertAfter.Next;
        }

        Node newNode = new Node(valueToInsert);
        nodeToInsertAfter.Next = newNode;
        this.length++;
    }

    // function to print the list
    public void Print() 
    {
        if (this.head == null)
        {
            Console.WriteLine("Linked list is empty.");
        }

        Node node = this.head;

        while (node != null)
        {
            Console.Write($"{node.Value} -> ");
            node = node.Next;
        }

        Console.WriteLine("null");
    }

    // function to delete a node
    public void Delete(int valueToDelete)
    {
        if (this.head == null)
        {
            throw new Exception("Cannot delete from an empty linked list.");
        }

        if (this.head.Value == valueToDelete)
        {
            Node node = this.head;
            this.head = node.Next;
            node.Next = null;
            node = null;
            this.length--;
            return;
        }

        Node previousNode = this.head;
        Node nextNode = this.head.Next;

        while (nextNode != null)
        {
            if (nextNode.Value == valueToDelete)
            {
                previousNode.Next = nextNode.Next;
                nextNode.Next = null;
                nextNode = null;
                this.length--;
                return;
            }

            nextNode = nextNode.Next;
            previousNode = previousNode.Next;
        }

        throw new Exception($"{valueToDelete} cannot be found.");
    }
    
    // function to search a node
    public bool Contains(int valueToSearch)
    {
        if (this.head == null)
        {
            return false;
        }

        Node node = this.head;

        while (node != null)
        {
            if (node.Value == valueToSearch)
            {
                return true;
            }

            node = node.Next;
        }

        return false;
    }

    // function to check if linkedlist is empty or not
    public bool IsEmpty()
    {
        return this.head == null;
    }
}