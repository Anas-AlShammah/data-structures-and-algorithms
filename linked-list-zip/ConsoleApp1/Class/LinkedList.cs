using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class LinkedList
    {
        public Node head {  get; set; }
        public Node tail { get; set; }
        public LinkedList() {
            head = null;
            tail = null;
        }
        public void Add (string data)
        {
            Node addnode = new Node(data);
            if (head == null)
            {
                head = addnode;
                tail = addnode;
            }
            else
            {
                tail.next = addnode;
                tail = addnode;
            }
        }
        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            Node start = head;

            while (start != null)
            {
                sb.AppendLine(start.data.ToString());
                start = start.next;
            }

            return sb.ToString();
        }

    }
}
