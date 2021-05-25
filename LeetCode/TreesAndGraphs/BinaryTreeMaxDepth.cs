using System;

namespace LeetCode.TreesAndGraphs
{
    class BinaryTreeMaxDepth
    {
        public int MaxDepth(TreeNode root)
        {
            //return MaxDepthBottomUp(root);
            MaxDepthTopDown(root);
            return answer;
        }

        private int answer = 0;
        private void MaxDepthTopDown(TreeNode root, int depth = 0)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
                answer = Math.Max(root.val, answer);

            MaxDepthTopDown(root.left, depth + 1);
            MaxDepthTopDown(root.right, depth + 1);
        }

        private int MaxDepthBottomUp(TreeNode root)
        {
            if (root == null) return 0;

            var leftMax = MaxDepthBottomUp(root.left);
            var rightMax = MaxDepthBottomUp(root.right);

            return Math.Max(leftMax, rightMax) + 1;
        }
    }
}
