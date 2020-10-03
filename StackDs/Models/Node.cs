namespace Models
{
    public class Node
    {
        private int value;
        private Node nextNode;

        public Node(int value, Node nextNode)
        {
            this.value = value;
            this.nextNode = nextNode;
        }

        public int Value 
        {
            get
            {
                return this.value;
            }
        }

        public Node Next 
        {
            get
            {
                return this.nextNode;
            }
            set
            {
                this.nextNode = value;
            }
        }
    }
}