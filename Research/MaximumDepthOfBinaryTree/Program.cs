using System;

namespace MaximumDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }
    }

    /// <summary>
    /// Definition for a binary tree node
    /// </summary>
    public class TreeNode
    {
        private int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}
