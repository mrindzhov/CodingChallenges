using CodingChallenges.LeetCode.Declarations;

namespace CodingChallenges.LeetCode.BinaryTree
{
    class DeleteNodeSolution
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return null;

            if (key < root.val)
                root.left = DeleteNode(root.left, key);
            else if (key > root.val)
                root.right = DeleteNode(root.right, key);
            else
            {
                if (root.left == null && root.right == null)
                    return null;
                else if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                else
                {
                    var minNode = FindMinNode(root.right);
                    root.val = minNode.val;
                    root.right = DeleteNode(root.right, minNode.val);
                }
            }

            return root;
        }

        private TreeNode FindMinNode(TreeNode node)
        {
            while (node.left != null)
                node = node.left;
            return node;
        }
    }
}
