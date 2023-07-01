using LinkedListInsertions;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var linkedlist = new LinkedList();
            //Act
            linkedlist.AppendNode("anas");
            //Assert
            Assert.Equal("anas", linkedlist.tail.data);
        }
        [Fact]
        public void Test2()
        {
            //arrange
            var linkedlist = new LinkedList();
            //Act
            linkedlist.AppendNode("anas");
            //Assert
            Assert.Equal("anas", linkedlist.tail.data);
            linkedlist.AppendNode("bassam");
            Assert.Equal("bassam", linkedlist.tail.data);
            linkedlist.AppendNode("Mohmmad");
            Assert.Equal("Mohmmad", linkedlist.tail.data);
        }
        [Fact]
        public void Test3()
        {
            var linkedlist = new LinkedList();
            //Act
            linkedlist.AppendNode("anas");
            linkedlist.AppendNode("bassam");
            linkedlist.AppendNode("Mohmmad");
            linkedlist.InsertBefore("bassam", "I`m Node before");
            //Assert
            Assert.Equal("I`m Node before", linkedlist.head.next.data);
        }
        [Fact]
        public void Test4()
        {
            var linkedlist = new LinkedList();
            //Act
            linkedlist.AppendNode("anas");
            linkedlist.AppendNode("bassam");
            linkedlist.AppendNode("Mohmmad");
            linkedlist.InsertBefore("anas", "I`m Node before");
            //Assert
            Assert.Equal("I`m Node before", linkedlist.head.data);

        }
        [Fact]
        public void Test5()
        {
            var linkedlist = new LinkedList();
            //Act
            linkedlist.AppendNode("anas");
            linkedlist.AppendNode("bassam");
            linkedlist.AppendNode("Mohmmad");
            linkedlist.InsertAfter("bassam", "I`m Node After");
            //Assert
            Assert.Equal("I`m Node After", linkedlist.head.next.next.data);
        }
        [Fact]
        public void Test6()
        {
            var linkedlist = new LinkedList();
            //Act
            linkedlist.AppendNode("anas");
            linkedlist.AppendNode("bassam");
            linkedlist.AppendNode("Mohmmad");
            linkedlist.InsertAfter("Mohmmad", "I`m Node After");
            Assert.Equal("I`m Node After", linkedlist.tail.data);
        }
    }
}