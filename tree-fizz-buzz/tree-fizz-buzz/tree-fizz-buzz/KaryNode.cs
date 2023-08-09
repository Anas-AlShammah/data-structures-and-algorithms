using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_fizz_buzz
{
    public class KaryNode
    {
        public int Value { get; set; }
        public List<KaryNode> Children { get; set; }

        public KaryNode(int value)
        {
            Value = value;
            Children = new List<KaryNode>();
        }
    }

}
