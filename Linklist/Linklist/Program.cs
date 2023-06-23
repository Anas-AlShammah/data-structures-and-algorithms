
namespace Linklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Node one = new Node("anas");

            //Node two = new Node("bassam");

            //Console.WriteLine(one.data);
            LinkList linklist = new LinkList();
            //linklist.Add("anas");
            //linklist.Add("bassam");
            //linklist.Add("ahmed");
            //linklist.Add("ali");
            //linklist.insert("mohmmad", 2);
            //linklist.ReplaceNode("hmmmad", 3);
            //linklist.Display();
            //linklist.Remove(1);
            //Console.WriteLine("Remove");
            linklist.InsertToHead("welcome");
            linklist.InsertToHead("here");
            //bool a=linklist.Includes("anas1");
            string print =linklist.ToString();
            Console.WriteLine(print);
            linklist.Display();
        }
    }
}