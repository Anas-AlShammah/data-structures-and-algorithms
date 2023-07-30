using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(string data) 
        {
            Node addNode = new Node(data);
            addNode.Next = Top;
            Top = addNode;
        }
        public void Display()
        {
            Node current = Top;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
        public Node Pop() {
            if (Top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            Node current = Top;
        
            Top = Top.Next;
            return current;

        }
        public Node Peek()
        {
            if (Top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return Top;
         
        }
        public bool IsEmpty()
        {
            if (Top == null)
            {
                Console.WriteLine("True");
                return true;
            }else
            {
                return false;
            }
        }

    }
}
