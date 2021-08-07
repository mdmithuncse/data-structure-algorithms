using System;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to tree traversal example");

            // Tree construction
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(12);
            tree.root.right = new Node(9);
            tree.root.left.left = new Node(5);
            tree.root.left.right = new Node(6);

            // Preorder traversal
            Console.WriteLine("Preorder tree traversal");
            tree.PreOrder(tree.root);
            Console.WriteLine();

            // Inorder traversal
            Console.WriteLine("Inorder tree traversal");
            tree.InOrder(tree.root);
            Console.WriteLine();

            // Postorder tree traversal
            Console.WriteLine("Postorder tree traversal");
            tree.PostOrder(tree.root);
        }
    }
}
