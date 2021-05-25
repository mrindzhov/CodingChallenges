using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            if (root == null) return res;
            //PostorderTraversalRecursive(root, res);
            PostorderTraversalIterative(root, res);
            return res;
        }

        private void PostorderTraversalIterative(TreeNode root, List<int> res)
        {
            var stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                if (root != null)
                {
                    stack.Push(root);
                    res.Insert(0, root.val);
                    root = root.right;
                }
                else
                {
                    var node = stack.Pop();
                    root = node.left;
                }
            }
        }

        private void PostorderTraversalRecursive(TreeNode root, List<int> res)
        {
            if (root == null) return;

            PostorderTraversalRecursive(root.left, res);
            PostorderTraversalRecursive(root.right, res);
            res.Add(root.val);
        }
    }
}
