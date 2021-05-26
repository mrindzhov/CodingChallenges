using System.Collections.Generic;
using CodingChallenges.LeetCode.Declarations;

namespace CodingChallenges.LeetCode.TopInterviewQuestions.TreesAndGraphs
{
    public class KthSmallestSolution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            return KthSmallestOp(root, k);
        }
        #region KthSmallestStraightForward

        private static int KthSmallestStraightForward(TreeNode root, int k)
        {
            var res = new List<int>();
            InorderTraversal(root, res);
            return res[k - 1];
        }

        private static void InorderTraversal(TreeNode root, List<int> result)
        {
            if (root == null) return;

            InorderTraversal(root.left, result);
            result.Add(root.val);
            InorderTraversal(root.right, result);
        }
        #endregion

        #region KthSmallestOp
        private int KthSmallestOp(TreeNode root, int k)
        {
            var list = new int[2];
            KthSmallestOpRecursive(root, k, list);
            return list[1];
        }

        public void KthSmallestOpRecursive(TreeNode root, int k, int[] numList)
        {
            if (root == null) return;

            KthSmallestOpRecursive(root.left, k, numList);

            numList[0] += 1;
            if (k == numList[0])
            {
                numList[1] = root.val;
                return;
            }

            KthSmallestOpRecursive(root.right, k, numList);
        }
        #endregion
    }
}
