using System.Collections.Generic;
using CodingChallenges.LeetCode.Declarations;

namespace CodingChallenges.LeetCode.BinaryTree
{
    public class IsSymmetricSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            //return IsSymmetricRecursive(root.left, root.right);
            return IsSymmetricIterative(root);
        }

        private bool IsSymmetricIterative(TreeNode root)
        {
            var nodesQueue = new Queue<TreeNode>();
            nodesQueue.Enqueue(root.left);
            nodesQueue.Enqueue(root.right);
            while (nodesQueue.Count > 0)
            {
                var node1 = nodesQueue.Dequeue();
                var node2 = nodesQueue.Dequeue();
                if (node1 == null && node2 == null) continue;
                if (node1 == null || node2 == null) return false;
                if (node1.val != node2.val) return false;
                nodesQueue.Enqueue(node1.left);
                nodesQueue.Enqueue(node2.right);

                nodesQueue.Enqueue(node1.right);
                nodesQueue.Enqueue(node2.left);
            }
            return true;
        }

        private bool IsSymmetricRecursive(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null) return false;

            return node1.val == node2.val
                && IsSymmetricRecursive(node1.left, node2.right)
                && IsSymmetricRecursive(node1.right, node2.left);
        }
    }
}
