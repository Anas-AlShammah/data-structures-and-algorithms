using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_kth
{
    public class LinkedList
    {
        public Node head { get; set; } = null;

        public Node tail { get; set; } = null;
        int count = 0;

        public void Add(int num)
        {
            count++;
            Node addNode = new Node(num);
            if (head == null) {
                head = addNode;
                tail = addNode;
            }else
            {
                tail.next = addNode;
                tail = addNode;
            }
        }
        public void Display()
        {
            Node start = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(start.data);
                start = start.next;
                
            }
        }
        public int DisplayKthFromEnd(int num)
        {
            if (num == 0)
            {
                
                return tail.data;
            }
            else if (num >= count || num<0)  throw new Exception("that out of index");
            else
            {

                for (int i = 1; i < num; i++)
                {
                    head = head.next;
                }
              
                return head.data;
            }
        }

    }
}
