using Models;

namespace Search
{
    public interface ITree
    {
        void Add(Node newNode);

        void PrintInOrder();
    }
}