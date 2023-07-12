using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }
        public void Enqueue (string data)
        {
            Node addNode = new Node (data);
            if (Front == null)
            {
                Front = addNode;
                Back = addNode;
            }
            else
            {

                Back.Next = addNode;
                Back = addNode;

            }
        }
        public Node Dequeue()
        {
            if (Front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            Node current = Front;
            Front = Front.Next;
            return current;
        }
        public Node Peek()
        {
            if (Front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            Node current = Front;
            return current;
        }
        public bool IsEmpty()
        {
            if (Front == null)
            {
                return true;
            }
            return false;
        }
    }
}
