using ConsoleApp1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Stack stack = new Stack();
            stack.Push("anas");
            Assert.Equal("anas",stack.Top.Value);
        }
        [Fact]
        public void Test2()
        {
            Stack stack = new Stack();
            stack.Push("anas");
            stack.Push("bassam");
            Assert.Equal("bassam", stack.Top.Value);
        }
        [Fact]
        public void Test3()
        {
            Stack stack = new Stack();
            stack.Push("anas");
            stack.Push("bassam");
            stack.Push("mohmmad");
            var res = stack.Pop();
            Assert.Equal("mohmmad", res.Value);
            Assert.Equal("bassam", stack.Top.Value);
        }
        [Fact]
        public void Test4()
        {
            Stack stack = new Stack();
            stack.Push("anas");
            stack.Push("bassam");
            stack.Push("mohmmad");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.Equal(true, stack.IsEmpty());
        }
        [Fact]
        public void Test5()
        {
            Stack stack = new Stack();
            stack.Push("anas");
            stack.Push("bassam");
            stack.Push("mohmmad");
            var res= stack.Peek();

            Assert.Equal("mohmmad", res.Value);
            Assert.Equal("mohmmad", stack.Top.Value);
        }
        [Fact]
        public void Test6()
        {
            Stack stack = new Stack();
            Assert.Equal(true, stack.IsEmpty());
        }
        [Fact]
        public void Test7()
        {
            Stack stack = new Stack();
           
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                stack.Peek();
            });
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                stack.Pop();
            });
        }
        [Fact]
        public void Test8()
        {
            Queue queue = new Queue();
            queue.Enqueue("anas");
            Assert.Equal("anas", queue.Front.Value);
        }
        [Fact]
        public void Test9()
        {
            Queue queue = new Queue();
            queue.Enqueue("anas");
            queue.Enqueue("bassam");
            Assert.Equal("anas", queue.Front.Value);
          
        }
        [Fact]
        public void Test10()
        {
            Queue queue = new Queue();
            queue.Enqueue("anas");
            queue.Enqueue("bassam");
            var res = queue.Dequeue();
            Assert.Equal("anas", res.Value);
            Assert.Equal("bassam", queue.Front.Value);

        }
        [Fact]
        public void Test11()
        {
            Queue queue = new Queue();
            queue.Enqueue("anas");
            queue.Enqueue("bassam");
            var res = queue.Peek();
            Assert.Equal("anas", res.Value);
            Assert.Equal("anas", queue.Front.Value);

        }
        [Fact]
        public void Test12()
        {
            Queue queue = new Queue();
            queue.Enqueue("anas");
            queue.Enqueue("bassam");
            queue.Dequeue();
            queue.Dequeue();
            
            Assert.Equal(true, queue.IsEmpty());

        }
        [Fact]
        public void Test13()
        {
            Queue queue = new Queue();
            Assert.True( queue.IsEmpty());
        }
        [Fact]
        public void Test14()
        {
            Queue queue = new Queue();
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                queue.Dequeue();
            });
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                queue.Peek();
            });
            
        }
    }
}