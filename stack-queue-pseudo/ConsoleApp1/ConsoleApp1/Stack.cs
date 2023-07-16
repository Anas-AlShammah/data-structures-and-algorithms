using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stack
    {
        private List<int> stack;

        public Stack()
        {
            stack = new List<int>();
        }

        public void Push(int item)
        {
            stack.Add(item);
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int lastIndex = stack.Count - 1;
            int item = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return item;
        }

        public int Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return stack[stack.Count - 1];
        }

        public int Count => stack.Count;

        public bool IsEmpty => stack.Count == 0;
    }

}
