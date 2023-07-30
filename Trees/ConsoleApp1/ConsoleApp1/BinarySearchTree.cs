using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            Root = AddRecursive(Root, value);
        }

        private Node AddRecursive(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }

            if (value < current.Value)
            {
                current.Left = AddRecursive(current.Left, value);
            }
            else if (value > current.Value)
            {
                current.Right = AddRecursive(current.Right, value);
            }

            return current;
        }

        public bool Contains(int value)
        {
            return ContainsRecursive(Root, value);
        }

        private bool ContainsRecursive(Node current, int value)
        {
            if (current == null)
            {
                return false;
            }

            if (current.Value == value)
            {
                return true;
            }

            if (value < current.Value)
            {
                return ContainsRecursive(current.Left, value);
            }
            else
            {
                return ContainsRecursive(current.Right, value);
            }
        }
    }

}
