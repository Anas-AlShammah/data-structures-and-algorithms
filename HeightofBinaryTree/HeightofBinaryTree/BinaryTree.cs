using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightofBinaryTree
{
    public class BinaryTree
    {
       public Node Root { get; set; }
       public int MaxDepth(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int LDepth = MaxDepth(node.Left);
                int RDepth = MaxDepth(node.Right);
                return Math.Max(LDepth, RDepth) ;
            }
        }
    }

}
