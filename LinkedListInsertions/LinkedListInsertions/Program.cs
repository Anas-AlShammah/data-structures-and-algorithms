using System.Collections.Generic;

namespace LinkedListInsertions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var listNodes = new LinkedList();
            listNodes.AppendNode("anas");
            listNodes.AppendNode("bassam");
            listNodes.AppendNode("hi");
            listNodes.AppendNode("there");
            listNodes.AppendNode("wellcome");
            listNodes.InsertBefore("anas", "hello");
            listNodes.InsertAfter("wellcome", "$$$$$$$$$$$$$");
            listNodes.Display();
        }
    }
}