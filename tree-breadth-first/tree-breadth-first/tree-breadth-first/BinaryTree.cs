using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_breadth_first
{
    public class BinaryTree
    {
        public Node root { get; set; }
      
        

        public List<int> BreadthFirstTraversal()
        {
            List<int> result = new List<int>();
            int height = GetTreeHeight(root);

            for (int level = 1; level <= height; level++)
            {
                TraverseLevel(root, level, result);
            }

            return result;
        }
        private int GetTreeHeight(Node node)
        {
            if (node == null)
                return 0;

            int leftHeight = GetTreeHeight(node.Left);
            int rightHeight = GetTreeHeight(node.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        private void TraverseLevel(Node node, int level, List<int> result)
        {
            if (node == null)
                return;

            if (level == 1)
            {
                result.Add(node.Data);
            }
            else if (level > 1)
            {
                TraverseLevel(node.Left, level - 1, result);
                TraverseLevel(node.Right, level - 1, result);
            }
        }
       
    }
}
