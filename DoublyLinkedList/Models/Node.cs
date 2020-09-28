namespace Models
{
    public class Node
    {
        private int nodeValue = 0;
        private Node previousNode = null;
        private Node nextNode = null;

        public Node(int value, Node previous = null, Node next = null)
        {
            this.nodeValue = value;
            this.previousNode = previous;
            this.nextNode = next;
        }

        public int Value 
        {
            get
            {
                return this.nodeValue;
            }
        }

        public Node PreviousNode
        {
            get
            {
                return this.previousNode;
            }
            set
            {
                this.previousNode = value;
            }
        }

        public Node NextNode
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