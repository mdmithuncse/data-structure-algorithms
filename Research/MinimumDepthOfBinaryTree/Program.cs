using System;

namespace MinimumDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MinDepth(root.left);
            int right = MinDepth(root.right);

            if (left == 0 || right == 0)
            {
                return left + right + 1;
            }

            return Math.Min(left, right) + 1;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        /// <summary>
        /// Definition for a binary tree node
        /// </summary>
        /// <param name="val"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
