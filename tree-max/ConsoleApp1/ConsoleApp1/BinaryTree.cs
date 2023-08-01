using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryTree
    {
        public Node root { get; set; }
        public  int FindMax(Node node)
        {
            if (node == null) return int.MinValue;
            int res = node.Data;
            int lres = FindMax(node.Left);
            int rres = FindMax(node.Right);
            if (lres > res)
            {
                res = lres;
            }
            if (rres > res)
            {
                res = rres;
            }
            return res;
        }
    }
}
