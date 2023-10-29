using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenticalTrees
{
    public class BinaryTree
    {
        public Node Root1, Root2;

        public virtual bool IdenticalTree (Node a , Node b)
        {
            if (a == null && b == null) return true;

            if (a != null && b != null )
            {
                return (a.Data == b.Data && IdenticalTree(a.Left, b.Left) && IdenticalTree(a.Right, b.Right));
            }
            return false;
        }
    }
}
