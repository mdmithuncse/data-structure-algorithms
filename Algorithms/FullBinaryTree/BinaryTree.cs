using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullBinaryTree
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        // Check for full binary tree
        public bool IsFullBinaryTree(Node node)
        {
            if (node == null)
                return true;

            if (node.left == null && node.right == null)
                return true;

            if (node.left != null && node.right != null)
                return IsFullBinaryTree(node.left) && IsFullBinaryTree(node.right);

            return false;
        }
    }
}
