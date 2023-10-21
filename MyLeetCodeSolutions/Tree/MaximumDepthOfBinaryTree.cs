namespace MyLeetCodeSolutions.Tree;

public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftD = MaxDepth(root.left) + 1;
        int rightD = MaxDepth(root.right) + 1;
        return leftD > rightD ? leftD : rightD;
    }
}