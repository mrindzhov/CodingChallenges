using System;

namespace LeetCode.TreesAndGraphs
{
    public class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0)
                return null;

            var mid = Array.IndexOf(inorder, preorder[0]);

            return new TreeNode(preorder[0])
            {
                left = BuildTree(preorder[1..(mid + 1)], inorder[..mid]),
                right = BuildTree(preorder[(mid + 1)..], inorder[(mid + 1)..]),
            };
        }
    }
}
