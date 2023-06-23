using Linklist;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestLinkList()
        {
            LinkList linklist1 = new LinkList();
            Assert.Null(linklist1.head);

        }
        [Fact]
        public void TestHead()
        {
            LinkList linklist = new LinkList();
            linklist.InsertToHead("anas");
            Assert.Equal("anas",linklist.head.data);

        }
        [Fact]
        public void TestInsertToHead()
        {
            LinkList linklist = new LinkList();
            linklist.InsertToHead("mohmmad");
            Assert.Equal("mohmmad", linklist.head.data);

        }
        [Fact]
        public void TestInsert()
        {
            LinkList linklist = new LinkList();
            linklist.InsertToHead("anas");
            linklist.InsertToHead("bassam");
            linklist.InsertToHead("mohmmad");
            Assert.Equal("mohmmad", linklist.head.data);
            Assert.Equal("bassam", linklist.head.next.data);
            Assert.Equal("anas", linklist.head.next.next.data);

        }
        [Fact]
        public void TestInCludesTrueAndFalse()
        {
            LinkList linklist = new LinkList();
            linklist.InsertToHead("anas");
            linklist.InsertToHead("bassam");
            linklist.InsertToHead("mohmmad");
            bool res = linklist.Includes("anas");
            bool res2 = linklist.Includes("ali");
            Assert.Equal(true, res);
            Assert.Equal(false, res2);
        }
        [Fact]
        public void ToStringTest()
        {
            LinkList linklist = new LinkList();
            linklist.InsertToHead("AlShammah");
            linklist.InsertToHead("mohmmad");
            linklist.InsertToHead("bassam");
            linklist.InsertToHead("anas");
            string res = linklist.ToString();
            Assert.Equal("{ anas } -> { bassam } -> { mohmmad } -> { AlShammah } -> NULL", res);
            
        }
    }
}