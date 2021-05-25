using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            if (root == null) return res;
            //PreorderTraversalRecursive(root, res);
            PreorderTraversalIterative(root, res);

            return res;
        }

        private void PreorderTraversalIterative(TreeNode root, List<int> res)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var treeNode = stack.Pop();
                res.Add(treeNode.val);

                if (treeNode.right != null) stack.Push(treeNode.right);
                if (treeNode.left != null) stack.Push(treeNode.left);
            }
        }

        private void PreorderTraversalRecursive(TreeNode root, List<int> res)
        {
            if (root == null) return;

            res.Add(root.val);

            PreorderTraversalRecursive(root.left, res);
            PreorderTraversalRecursive(root.right, res);
        }
    }
}
