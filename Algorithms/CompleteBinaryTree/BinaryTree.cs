
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteBinaryTree
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        // Count total number of nodes
        public int CountNumberOfNodes(Node node)
        {
            if (node == null)
                return 0;

            return 1 + CountNumberOfNodes(node.left) + CountNumberOfNodes(node.right);
        }

        // Check for complete binary tree
        public bool IsCompleteBinaryTree(Node node, int index, int numberOfNodes)
        {
            if (node == null)
                return true;

            if (index >= numberOfNodes)
                return false;

            return IsCompleteBinaryTree(node.left, 2 * index + 1, numberOfNodes) && IsCompleteBinaryTree(node.right, 2 * index + 2, numberOfNodes);
        }
    }
}
