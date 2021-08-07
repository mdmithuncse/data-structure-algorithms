using System;

namespace CompleteBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to complete binary tree check example");

            // Tree construction
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);

            int nodeCount = tree.CountNumberOfNodes(tree.root);
            int index = 0;

            // Check for complete binary tree
            if (tree.IsCompleteBinaryTree(tree.root, index, nodeCount))
            {
                Console.WriteLine("This is a complete binary tree");
            }

            else
            {
                Console.WriteLine("This isn't a complete binary tree");
            }
        }
    }
}
