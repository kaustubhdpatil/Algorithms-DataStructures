public interface IQueue
{
    void Enqueue(int value);

    int Dequeue();

    bool IsEmpty();

    int Peek();
}