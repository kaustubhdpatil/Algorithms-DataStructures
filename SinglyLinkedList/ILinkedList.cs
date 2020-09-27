using Model;

public interface ILinkedList
{
    Node Head {get;}

    void InsertAtTheEnd(int valueToInsert);

    void Print();

    void Delete(int valueToDelete);

    bool Contains(int valueToSearch);
}