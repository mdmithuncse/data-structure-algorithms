using System;

namespace FullBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to full binary tree check example");

            // Tree construction
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);

            // Check full binary tree
            Console.WriteLine("Check full binary tree");
            if (tree.IsFullBinaryTree(tree.root))
                Console.WriteLine("The tree is a full binary tree");
            else
                Console.WriteLine("The tree isn't a full binary tree");
        }
    }
}
