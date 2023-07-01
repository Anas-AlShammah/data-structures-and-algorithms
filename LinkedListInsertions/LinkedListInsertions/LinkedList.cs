using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertions
{
    public class LinkedList
    {
        public Node head { get; set; } = null;
        public Node tail { get; set; } = null;
        int count =0;
        public LinkedList() {
            count++;
        }
        public void Add(string data)
        {
            var addNode = new Node(data);
            if (head == null)
            {
                head = addNode;
                tail = addNode;
            }
            else
            {
                tail.next = addNode;
                tail = addNode;
            }
        }
        public void Display()
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
        public void AppendNode (string data)
        {
            var addNode =new Node(data);
            if (head == null)
            {
                head = addNode;
                tail = addNode;
            }
            else
            {
                tail.next= addNode;
                tail = addNode;
            }
        }
        public void InsertBefore(string data1,string data2)
        {
            var currentNode = head;
            Node prevNode = null ;
            while (currentNode.data != data1)
            {
                prevNode = currentNode;
                currentNode = currentNode.next;
            }
            var addNode =new Node(data2);
            if (prevNode != null) { 
            prevNode.next = addNode;
            addNode.next = currentNode;
            }else
            {
                head = addNode;   
                addNode.next = currentNode;
            }


        }

        public void InsertAfter (string data1,string data2)
        {
            var currentNode = head;
          //  var prevNode = head;
            while (currentNode.data != data1)
            {
               // prevNode = currentNode;
                currentNode = currentNode.next;
            }
            var addNode = new Node(data2);
            if (currentNode != tail) { 
            addNode.next = currentNode.next;
            currentNode.next = addNode;
            }else
            {
                tail.next = addNode;
                tail = addNode;
             

            }

        }
    }
}
