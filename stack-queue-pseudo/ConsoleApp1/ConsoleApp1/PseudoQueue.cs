using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PseudoQueue : IQueue
    {
        private Stack inbox;
        private Stack outbox;
        public PseudoQueue()
        {
            inbox = new Stack();
            outbox = new Stack();
        }
        public int Dequeue()
        {
            if (outbox.IsEmpty)
            {
                while (!inbox.IsEmpty)
                {
                    outbox.Push(inbox.Pop());
                }
            }

            return outbox.Pop();
        }

        public void Enqueue(int value)
        {
            inbox.Push(value);
        }
    }
}
