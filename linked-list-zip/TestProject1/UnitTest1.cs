using ConsoleApp1.Class;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add("ANas");
            list1.Add("bassam");
            list1.Add("mohmmad");
            list1.Add("Al-Shammah");

            LinkedList list2 = new LinkedList();
            list2.Add("hi");
            list2.Add("there");

            LinkedList expectedList = new LinkedList();
            expectedList.Add("ANas");
            expectedList.Add("hi");
            expectedList.Add("bassam");
            expectedList.Add("there");
            expectedList.Add("mohmmad");
            expectedList.Add("Al-Shammah");

            // Act
            ZipLinkedList zipLinkedList = new ZipLinkedList(list1, list2);
            LinkedList actualList = zipLinkedList.newLinkedList;

            // Assert
            Assert.Equal(expectedList.Display(), actualList.Display());
        }
        [Fact]
        public void Test2()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add("ANas");
            list1.Add("bassam");
            list1.Add("mohmmad");
            list1.Add("Al-Shammah");

            LinkedList list2 = new LinkedList();
            list2.Add("hi");
            list2.Add("there");
            list2.Add("hi");
            list2.Add("there");
            list2.Add("hi");
            list2.Add("there");

            LinkedList expectedList = new LinkedList();
            expectedList.Add("ANas");
            expectedList.Add("hi");
            expectedList.Add("bassam");
            expectedList.Add("there");
            expectedList.Add("mohmmad");
            expectedList.Add("hi");
            expectedList.Add("Al-Shammah");
            expectedList.Add("there");
            expectedList.Add("hi");
            expectedList.Add("there");

            // Act
            ZipLinkedList zipLinkedList = new ZipLinkedList(list1, list2);
            LinkedList actualList = zipLinkedList.newLinkedList;

            // Assert
            Assert.Equal(expectedList.Display(), actualList.Display());
        }
        [Fact]
        public void Test3()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add("ANas");

            LinkedList list2 = new LinkedList();
            list2.Add("hi");
            list2.Add("there");

            LinkedList expectedList = new LinkedList();
            expectedList.Add("ANas");
            expectedList.Add("hi");

            expectedList.Add("there");

            // Act
            ZipLinkedList zipLinkedList = new ZipLinkedList(list1, list2);
            LinkedList actualList = zipLinkedList.newLinkedList;

            // Assert
            Assert.Equal(expectedList.Display(), actualList.Display());
        }
    }
}