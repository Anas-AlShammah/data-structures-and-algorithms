namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue queue = new PseudoQueue();

            // Enqueue values
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);

            // Dequeue values
            int value1 = queue.Dequeue();
            int value2 = queue.Dequeue();

            Console.WriteLine(value1); // Output: 10
            Console.WriteLine(value2); // Output: 15
        }
    }
}