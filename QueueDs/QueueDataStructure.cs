using Models;
using System;

public class QueueDataStructure : IQueue
{
    private Node head;

    public void Enqueue(int value)
    {
        if (this.head == null)
        {
            this.head = new Node(value, null);
            return;
        }

        Node node = this.head;

        while (node.Next != null)
        {
            node = node.Next;
        }

        node.Next = new Node(value, null);
    }

    public int Dequeue()
    {
        if (this.head == null)
        {
            throw new Exception("Cannot dequeue from an empty Queue.");
        }

        int result = this.head.Value;
        Node node = this.head;
        this.head = node.Next;
        node.Next = null;
        node = null;
        return result;
    }

    public bool IsEmpty()
    {
        return this.head == null;
    }

    public int Peek()
    {
        if (this.head == null)
        {
            throw new Exception("Cannot peek as the Queue is empty.");
        }

        return this.head.Value;
    }
}