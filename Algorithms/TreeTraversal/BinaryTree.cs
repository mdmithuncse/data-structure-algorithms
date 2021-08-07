using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        // Preorder traversal
        public void PreOrder(Node node)
        {
            if (node == null)
                return;

            // Display root
            Console.WriteLine($"{node.item}");

            // Traverse left
            PreOrder(node.left);

            // Traverse right
            PreOrder(node.right);
        }

        // Inorder traversal
        public void InOrder(Node node)
        {
            if (node == null)
                return;
            
            // Traverse left
            InOrder(node.left);

            // Display root
            Console.WriteLine($"{node.item}");


            // Traverse right
            InOrder(node.right);
        }

        // Postorder traversal
        public void PostOrder(Node node)
        {
            if (node == null)
                return;

            // Traverse left
            PostOrder(node.left);

            // Traverse right
            PostOrder(node.right);

            // Display root
            Console.WriteLine($"{node.item}");
        }
    }
}
