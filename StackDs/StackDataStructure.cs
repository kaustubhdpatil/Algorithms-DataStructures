using Models;
using System;

public class StackDataStructure : IStack
{
    private Node head;

    public int Top
    {
        get
        {
            return this.head == null ? -1 : this.head.Value;
        }
    }

    public void Push(int value)
    {
        if (this.head == null)
        {
            this.head = new Node(value, null);
            return;
        }

        Node node = this.head;
        this.head = new Node(value, node);
    }

    public int Pop()
    {
        if (this.head == null)
        {
            throw new Exception("Cannot pop from an empty stack");
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
        return this.head.Value;
    }
}