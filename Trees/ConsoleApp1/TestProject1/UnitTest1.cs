using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            BinaryTree binaryTree = new BinaryTree();
            Assert.Null(binaryTree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRoot()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            Assert.NotNull(binaryTree.Root);
            Assert.Equal(1, binaryTree.Root.Value);
        }

        [Fact]
        public void BinarySearchTree_AddLeftAndRightChild()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);

            Assert.Equal(30, binarySearchTree.Root.Left.Value);
            Assert.Equal(70, binarySearchTree.Root.Right.Value);
        }

        [Fact]
        public void PreOrderTraversal_ReturnsCorrectCollection()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(5);
            binaryTree.Root.Right.Left = new Node(6);
            binaryTree.Root.Right.Right = new Node(7);

            var expected = new int[] { 1, 2, 4, 5, 3, 6, 7 };
            Assert.Equal(expected, binaryTree.PreOrderTraversal());
        }

        [Fact]
        public void InOrderTraversal_ReturnsCorrectCollection()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(5);
            binaryTree.Root.Right.Left = new Node(6);
            binaryTree.Root.Right.Right = new Node(7);

            var expected = new int[] { 4, 2, 5, 1, 6, 3, 7 };
            Assert.Equal(expected, binaryTree.InOrderTraversal());
        }

        [Fact]
        public void PostOrderTraversal_ReturnsCorrectCollection()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(5);
            binaryTree.Root.Right.Left = new Node(6);
            binaryTree.Root.Right.Right = new Node(7);

            var expected = new int[] { 4, 5, 2, 6, 7, 3, 1 };
            Assert.Equal(expected, binaryTree.PostOrderTraversal());
        }

        [Fact]
        public void BinarySearchTree_ContainsReturnsTrueIfValueExists()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(20);
            binarySearchTree.Add(40);

            Assert.True(binarySearchTree.Contains(30));
            Assert.True(binarySearchTree.Contains(70));
            Assert.True(binarySearchTree.Contains(20));
            Assert.True(binarySearchTree.Contains(40));
        }

        [Fact]
        public void BinarySearchTree_ContainsReturnsFalseIfValueDoesNotExist()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);

            Assert.False(binarySearchTree.Contains(10));
            Assert.False(binarySearchTree.Contains(60));
            Assert.False(binarySearchTree.Contains(80));
        }
    }
}