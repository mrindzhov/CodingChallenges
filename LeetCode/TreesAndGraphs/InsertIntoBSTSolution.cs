namespace LeetCode.TreesAndGraphs
{
    class InsertIntoBSTSolution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            return InsertIntoBSTRecursive(root, val);
        }

        private TreeNode InsertIntoBSTRecursive(TreeNode root, int val)
        {
            if (root == null)
                return new TreeNode(val);

            if (val < root.val)
                root.left = InsertIntoBSTRecursive(root.left, val);
            else
                root.right = InsertIntoBSTRecursive(root.right, val);

            return root;
        }

        public TreeNode InsertIntoBSTNaive(TreeNode root, int val)
        {
            if (root == null)
                return new TreeNode(val);

            InsertIntoBSTNaiveRecursive(root, val);
            return root;
        }

        private void InsertIntoBSTNaiveRecursive(TreeNode root, int val)
        {
            if (root == null)
                return;

            if (val < root.val)
            {
                InsertIntoBST(root.left, val);
                if (root.left == null)
                    root.left = new TreeNode(val);
            }
            else
            {
                InsertIntoBST(root.right, val);
                if (root.right == null)
                    root.right = new TreeNode(val);
            }
        }
    }
}
