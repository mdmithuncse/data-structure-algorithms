using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class Node
    {
        public int item;
        public Node left, right;
        
        public Node(int key)
        {
            item = key;
            left = right = null;
        }
    }
}
