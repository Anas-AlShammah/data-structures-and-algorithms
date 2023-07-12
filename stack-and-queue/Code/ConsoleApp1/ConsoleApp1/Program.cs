namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("anas");
            stack.Push("bassam");
            stack.Push("al-shammah");
            Console.WriteLine(stack.Top.Value);
            Console.WriteLine(stack.IsEmpty());
            Queue queue = new Queue();
            queue.Enqueue("anas");
            queue.Enqueue("bassam");
            Console.WriteLine(queue.Front.Value);
        }
    }
}