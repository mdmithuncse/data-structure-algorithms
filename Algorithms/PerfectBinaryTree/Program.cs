using System;

namespace PerfectBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to perfect binary tree check example");

            // Tree construction
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);

            // Check for the perfect binary tree
            if (tree.IsPerfectBinaryTree(tree.root))
            {
                Console.WriteLine("This is a perfect binary tree");
            }

            else
            {
                Console.WriteLine("This isn't a perfect binary tree");
            }
        }
    }
}
