using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_kth
{
    public class Node
    {
        public Node next { get; set; } = null;

        public int data { get; set; } 
        public Node(int num) {
        data = num;
        }

    }
}
