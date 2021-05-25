using System.Linq;

namespace LeetCode.TreesAndGraphs
{
    public class ConstructBinaryTreefromInorderandPostorderTraversal
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (postorder.Length == 0 || inorder.Length == 0)
                return null;

            var inorderIdxMap = inorder.Select((num, idx) => (num, idx)).ToDictionary(n => n.num, n => n.idx);

            return BuildTreeRecursive(0, inorder.Length - 1, 0, postorder.Length - 1);


            TreeNode BuildTreeRecursive(int inStart, int inEnd, int postStart, int postEnd)
            {
                if (inStart > inEnd || postStart > postEnd)
                    return null;

                var rootVal = postorder[postEnd];
                var rootIdx = inorderIdxMap[rootVal];

                return new TreeNode(rootVal)
                {
                    left = BuildTreeRecursive(inStart, rootIdx - 1, postStart, postStart + rootIdx - inStart - 1),
                    right = BuildTreeRecursive(rootIdx + 1, inEnd, postStart + rootIdx - inStart, postEnd - 1),
                };
            }
        }
    }
}
