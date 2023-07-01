using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertions
{
    public class Node
    {
        public Node next;
        public string data { get; set; }
        public Node(string data) {
            next = null;
            this.data = data;
        }
    }
}
