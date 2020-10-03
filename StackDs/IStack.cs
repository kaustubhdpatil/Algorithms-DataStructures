public interface IStack
{
    int Top {get;}

    int Pop();

    void Push(int value);

    bool IsEmpty();

    int Peek();
}