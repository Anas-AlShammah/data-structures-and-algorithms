using tree_breadth_first;

namespace TestProject1
{
    public class UnitTest1
    {
       
       [Fact]
        public void TestBreadthFirstTraversal()
        {
            
            Node root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            root.Right.Left = new Node(6);
            root.Right.Right = new Node(7);

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.root = root;

          
            List<int> expectedTraversal = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            
            List<int> actualTraversal = binaryTree.BreadthFirstTraversal();

            
            Assert.Equal(expectedTraversal, actualTraversal);
        }
        
    }
}