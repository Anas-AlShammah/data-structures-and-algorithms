namespace TestProject1
{
    public class MergeSortTests
    {
        [Fact]
        public void TestMergeSort()
        {
            // Arrange
            int[] unsortedArray = { 8, 4, 23, 42, 16, 15 };
            int[] expectedSortedArray = { 4, 8, 15, 16, 23, 42 };

            // Act
            MergeSort.MergeSortAlgorithm(unsortedArray);

            // Assert
            Assert.Equal(expectedSortedArray, unsortedArray);
        }

        [Fact]
        public void TestEmptyArray()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act
            MergeSort.MergeSortAlgorithm(emptyArray);

            // Assert
            Assert.Empty(emptyArray);
        }

        [Fact]
        public void TestAlreadySortedArray()
        {
            // Arrange
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5 };

            // Act
            MergeSort.MergeSortAlgorithm(sortedArray);

            // Assert
            Assert.Equal(expectedSortedArray, sortedArray);
        }

        [Fact]
        public void TestReverseSortedArray()
        {
            // Arrange
            int[] reverseSortedArray = { 5, 4, 3, 2, 1 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5 };

            // Act
            MergeSort.MergeSortAlgorithm(reverseSortedArray);

            // Assert
            Assert.Equal(expectedSortedArray, reverseSortedArray);
        }
    }
}