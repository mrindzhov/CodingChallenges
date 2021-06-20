using System.Collections.Generic;
using System.Linq;
using CodingChallenges.LeetCode.Declarations;

namespace CodingChallenges.LeetCode.TopInterviewQuestions.TreesAndGraphs
{
    public class PopulatingNextRightPointersinEachNodeSolution
    {
        public Node Connect(Node root)
        {
            if (root == null) return null;
            //ConnectRecursive(root);
            ConnectIterative(root);
            return root;
        }

        private void ConnectRecursive(Node root)
        {
            if (root.left == null) return;

            root.left.next = root.right;
            if (root.next != null)
                root.right.next = root.next.left;

            ConnectRecursive(root.left);
            ConnectRecursive(root.right);
        }

        private static void ConnectIterative(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var currNode = queue.Dequeue();
                    currNode.next = i <= size - 1 && queue.Any() ? queue.Peek() : null;
                    if (currNode.left != null) queue.Enqueue(currNode.left);
                    if (currNode.right != null) queue.Enqueue(currNode.right);
                }
            }
        }
    }
}
