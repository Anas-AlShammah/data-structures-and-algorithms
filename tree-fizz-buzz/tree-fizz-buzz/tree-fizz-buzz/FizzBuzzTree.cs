using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_fizz_buzz
{
    public class FizzBuzzTree
    {
        public KaryNode FizzBuzz(KaryNode root)
        {
            if (root == null)
                return null;

            KaryNode newRoot = FizzBuzzHelper(root); 

            return newRoot;
        }

        private KaryNode FizzBuzzHelper(KaryNode oldNode)
        {
            int newValue = oldNode.Value; 

       
            if (newValue % 3 == 0 && newValue % 5 == 0)
                newValue = 0;
            else if (newValue % 3 == 0)
                newValue = 1; 
            else if (newValue % 5 == 0)
                newValue = 2; 

            KaryNode newNode = new KaryNode(newValue);

            foreach (var child in oldNode.Children)
            {
                newNode.Children.Add(FizzBuzzHelper(child)); 
            }

            return newNode;
        }




    }


}
