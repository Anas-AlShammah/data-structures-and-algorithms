using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist
{
    public  class Node
    {
        public string data { get; set; }

        public Node next;

        public static int count = 0;

        public Node(string data) 
        { 
        this.data = data;
            next = null;
            count++;
        }
    }
}
