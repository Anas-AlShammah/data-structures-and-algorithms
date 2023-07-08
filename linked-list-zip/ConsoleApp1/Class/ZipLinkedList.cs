using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class ZipLinkedList
    {
        public LinkedList list {  get; set; }
        public LinkedList list2 { get; set; }
        public LinkedList newLinkedList { get; } = new LinkedList();
        public  ZipLinkedList(LinkedList listsend1, LinkedList listsend2)
        {
            this.list = listsend1;
            this.list2 = listsend2;
            newLinkedList = ZipLinked();



        }
        public LinkedList ZipLinked()
        {
            Node start = list.head;
            Node start2 = list2.head;
            while (start != null || start2 != null)
            {
                if (start != null)
                {
                    newLinkedList.Add(start.data);
                    start = start.next;
                }
                if (start2 != null)
                {
                    newLinkedList.Add(start2.data);
                    start2 = start2.next;
                }

            }
            return newLinkedList;
        }
    }
}
