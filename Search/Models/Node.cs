namespace Models
{
    public class Node : ISearchModel<int>
    {
        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }
    }
}