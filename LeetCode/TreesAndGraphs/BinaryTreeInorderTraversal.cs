using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            //InorderTraversalRecursive(root, result);
            InorderTraversalIterative(root, result);
            return result;
        }

        private void InorderTraversalIterative(TreeNode root, List<int> result)
        {
            var stack = new Stack<TreeNode>();

            while (root != null || stack.Count > 0)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    var node = stack.Pop();
                    result.Add(node.val);
                    root = node.right;
                }
            }
        }

        private void InorderTraversalRecursive(TreeNode root, List<int> result)
        {
            if (root == null) return;

            InorderTraversalRecursive(root.left, result);
            result.Add(root.val);
            InorderTraversalRecursive(root.right, result);
        }
    }
}
