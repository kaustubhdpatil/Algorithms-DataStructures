using Models;
namespace Search
{
    public interface ISearchable
    {
        int Search(Node rootNode, int searchData);
    }
}