using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomQueue<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node front;
        private Node rear;

        public void Enqueue(T data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }


}
