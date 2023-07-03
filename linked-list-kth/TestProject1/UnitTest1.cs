using linked_list_kth;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Action action = () => list.DisplayKthFromEnd(6);
            Assert.Throws<Exception>(action);
        }
        [Fact]
        public void Test2()
        {
            var list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Action action = () => list.DisplayKthFromEnd(3);
            Assert.Throws<Exception>(action);
        }
        [Fact]
        public void Test3()
        {
            var list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Action action = () => list.DisplayKthFromEnd(-1);
            Assert.Throws<Exception>(action);
        }
        [Fact]
        public void Test4()
        {
            var list = new LinkedList();
            list.Add(1);
            var res = list.DisplayKthFromEnd(0); 
            Assert.Equal(1, res);
        }
        [Fact]
        public void Test5()
        {
            var list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(9);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            var res = list.DisplayKthFromEnd(3);
            Assert.Equal(9, res);

        }
    }
}