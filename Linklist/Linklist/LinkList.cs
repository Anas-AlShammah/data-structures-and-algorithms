using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist
{
    public class LinkList
    {
        public Node head;

        public Node tail;

        public LinkList()
        {
            head = null;
            tail = null;
        }

        //public void Add(string data)
        //{
        //    Node newNode = new Node(data);
        //    if (head != null)
        //    {
        //        tail.next = newNode;
        //        tail = newNode;
        //    }
        //    else
        //    {
        //        head = newNode;
        //        tail = newNode;
        //    }
        //}
        public void Display()
        {
            Node start = head;
            if (start == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                while (start != null)
                {
                    Console.WriteLine(start.data);
                    start = start.next;
                }
            }
        }
        //public void insert(string data, int position)
        //{
        //    Node InsertNode = new Node(data);
        //    if (position <= 0)
        //    {
        //        Add(data);
        //    }
        //    else if (position >= Node.count) { Add(data); }
        //    else
        //    {
        //        Node start = head;
        //        Node prevNode = null;
        //        int index = 0;
        //        while (start != null && position > index)
        //        {
        //            prevNode = start;
        //            start = start.next;
        //            index++;
        //        }
        //        prevNode.next = InsertNode;
        //        InsertNode.next = start;
               

        //    }

        //}
        //public void ReplaceNode(string data, int position)
        //{
        //    Node replace = new Node(data);
        //    Node currentNode = head;
        //    int index = 0;
        //    while (index < position)
        //    {
        //        currentNode = head.next;
        //        index++;
        //    }
        //    currentNode.data = replace.data;

        //}
        //public void Remove(int postion)
        //{
        //    int index = 0;
        //    Node Current = head;
        //    Node prev = null;
        //    Node NextNode = null;
        //    while (postion > index)
        //    {
        //        prev = Current;
        //        Current = Current.next;
        //        NextNode = Current.next;
        //        index++;
        //    }
        //    prev.next = NextNode;
            



        //}
        public void InsertToHead(string data)
        {
            Node AddNode = new Node(data);
            if (head == null)
            {
                head = AddNode;
                tail = AddNode;
            }
            else
            {
                AddNode.next = head;
                head = AddNode;
            }

        }
        public bool Includes(string data)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.data == data) return true;

                currentNode = currentNode.next;
            }
            return false;
        }
        public string ToString()
        {
            string ans = "";
            Node CurrentNode = head;
            while (CurrentNode != null)
            {
                if (CurrentNode != tail) { 
                ans += "{ " + CurrentNode.data + " } -> ";
                }else
                {
                    ans += "{ " + CurrentNode.data + " } -> NULL";
                }
                CurrentNode = CurrentNode.next;
            }
            return ans;
        }
    }
}
