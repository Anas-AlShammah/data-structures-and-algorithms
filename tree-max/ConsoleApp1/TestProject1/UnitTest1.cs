using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void FindMax_ShouldReturnMaxValue_WhenTreeIsNotEmpty()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(10);
            tree.root.Left = new Node(5);
            tree.root.Right = new Node(20);
            tree.root.Left.Left = new Node(3);
            tree.root.Left.Right = new Node(7);

            // Act
            int result = tree.FindMax(tree.root);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FindMax_ShouldReturnMinValue_WhenTreeIsEmpty()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            int result = tree.FindMax(tree.root);

            // Assert
            Assert.Equal(int.MinValue, result);
        }
    }
}