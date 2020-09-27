namespace Model
{
    public class Node
    {
        private int nodeValue;

        public Node(int value)
        {
            this.nodeValue = value;
        }

        public int Value
        {
            get
            {
                return this.nodeValue;
            }
        }
        public Node Next { get; set; }
    }
}