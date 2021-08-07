using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectBinaryTree
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        // Calculate depth
        public static int Depth(Node node)
        {
            int d = 0;

            while(node != null)
            {
                d++;
                node = node.left;
            }

            return d;
        }

        // Check for the perfect binary tree
        private bool IsPerfectBinaryTree(Node node, int depth, int level)
        {
            if (node == null)
                return true;

            if (node.left == null && node.right == null)
                return (depth == level + 1);

            return IsPerfectBinaryTree(node.left, depth, level + 1) && IsPerfectBinaryTree(node.right, depth, level + 1);
        }

        // Check for the perfect binary tree
        public bool IsPerfectBinaryTree(Node node)
        {
            int depth = Depth(node);
            return IsPerfectBinaryTree(node, depth, 0);
        }
    }
}
