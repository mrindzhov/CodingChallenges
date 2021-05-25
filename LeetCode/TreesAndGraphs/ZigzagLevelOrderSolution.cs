using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class ZigzagLevelOrderSolution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var res = new List<List<int>>();
            if (root == null) return res.ToArray();

            //ZigZagTraverseRecursive(root, res, 1);
            ZigzagLevelOrderIterative(root, res);
            return res.ToArray();
        }

        private void ZigzagLevelOrderIterative(TreeNode root, List<List<int>> res)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var isReverse = false;
            while (queue.Count > 0)
            {
                var list = new List<int>();
                var queueCount = queue.Count;

                for (int i = 0; i < queueCount; i++)
                {
                    var current = queue.Dequeue();

                    if (isReverse) list.Insert(0, current.val);
                    else list.Add(current.val);

                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }

                res.Add(list);
                isReverse = !isReverse;
            }
        }

        private void ZigZagTraverseRecursive(TreeNode root, List<List<int>> res, int level)
        {
            if (root == null) return;
            if (res.Count < level) res.Add(new List<int>());
            if (level % 2 == 1) res[level - 1].Add(root.val);
            else res[level - 1].Insert(0, root.val);

            ZigZagTraverseRecursive(root.left, res, level + 1);
            ZigZagTraverseRecursive(root.right, res, level + 1);
        }
    }
}
