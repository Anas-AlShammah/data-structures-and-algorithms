using ConsoleApp1.Class;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("ANas");
            list.Add("bassam");
            list.Add("mohmmad");
            list.Add("Al-Shammah");

            LinkedList list2 = new LinkedList();
            list2.Add("First Name");
            list2.Add("Second Name");

            var zipLinked = new ZipLinkedList(list, list2);

            Console.Write(zipLinked.newLinkedList.Display());

        }
    }
}