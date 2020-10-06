using Models;

public interface IBinaryTree
{
    TreeNode Root {get;}

    void PrintTreeInOrder();

    void PrintTreePreOrder();

    void PrintTreeInLevelOrder();

    void LevelOrderInsertion(int value);

    void DeleteNode(int value);
}