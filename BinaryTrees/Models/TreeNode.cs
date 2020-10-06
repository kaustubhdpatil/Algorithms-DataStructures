namespace Models
{
    public class TreeNode
    {
        int nodeValue;
        TreeNode leftChild;
        TreeNode rightChild;

        public TreeNode(int nodeValue):this(nodeValue, null, null)
        {}

        public TreeNode(int nodeValue, TreeNode left, TreeNode right)
        {
            this.nodeValue = nodeValue;
            this.leftChild = left;
            this.rightChild = right;
        }

        public int Value
        {
            get
            {
                return this.nodeValue;
            }
        }

        public TreeNode Left
        {
            get
            {
                return this.leftChild;
            }
            set
            {
                this.leftChild = value;
            }
        }

        public TreeNode Right
        {
            get
            {
                return this.rightChild;
            }
            set
            {
                this.rightChild = value;
            }
        }
    }
}