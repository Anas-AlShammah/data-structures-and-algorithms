namespace linked_list_kth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listNodes = new LinkedList();
            listNodes.Add(1);
            listNodes.Add(3);
            listNodes.Add(5);
            listNodes.Add(9);
            listNodes.Display();
            Console.WriteLine(listNodes.DisplayKthFromEnd(4));
            
        }
    }
}