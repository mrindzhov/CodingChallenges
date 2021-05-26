using CodingChallenges.LeetCode.Declarations;

namespace CodingChallenges.LeetCode.BinaryTree
{
    public class SearchBSTSolution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            return SearchBSTRecursive(root, val);
        }

        public TreeNode SearchBSTRecursive(TreeNode root, int val)
        {
            if (root == null || root.val == val)
                return root;

            return val < root.val
                    ? SearchBSTRecursive(root.left, val)
                    : SearchBSTRecursive(root.right, val);
        }
    }
}
