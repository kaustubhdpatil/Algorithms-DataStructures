using Models;

public interface ILinkedList
{
    int Length {get;}

    Node Head {get;}

    void InsertAtTheEnd(int valueToInsert);

    void Print();

    void Delete(int valueToDelete);

    bool Contains(int valueToSearch);

    bool IsEmpty();
}