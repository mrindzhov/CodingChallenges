using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Design
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Executor
    {
        public void Execute()
        {
            Codec ser = new Codec();
            Codec deser = new Codec();
            TreeNode root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
            };
            var data = ser.serialize(root);
            Console.WriteLine(data);
            TreeNode resNode = deser.deserialize(data);
            printNode(resNode);

        }

        private void printNode(TreeNode resNode)
        {
            if (resNode == null) return;

            Console.WriteLine(resNode.val);

            printNode(resNode.left);
            printNode(resNode.right);
        }
    }

    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return "X,";

            var leftSerialized = serialize(root.left);
            var rightSerialized = serialize(root.right);
            return root.val + "," + leftSerialized + rightSerialized;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            //1,2,X,X,3,4,X,X,5,X,X,
            var queue = new Queue<string>(data.Split(",").ToArray());

            var rootNode = RecurseTreeNodeQueue(queue);
            return rootNode;
        }

        private TreeNode RecurseTreeNodeQueue(Queue<string> queue)
        {
            string val = queue.Dequeue();
            return val == "X" || queue.Count == 0
                ? null
                : new TreeNode(int.Parse(val))
                {
                    left = RecurseTreeNodeQueue(queue),
                    right = RecurseTreeNodeQueue(queue)
                };
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // TreeNode ans = deser.deserialize(ser.serialize(root));
}
