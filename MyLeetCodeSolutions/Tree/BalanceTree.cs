using System.Data;
using myLeetCodeSolutions.String;

namespace MyLeetCodeSolutions.Tree;

public class BalanceTree
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        TreeNode root = new TreeNode(nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            Add(root, nums[i]);
        }

        return root;
    }

    public void RightRotate(TreeNode root)
    {
        TreeNode tempRoot = root;
        root = tempRoot.left;
        if (root.right != null)
        {
            tempRoot.left = root.right;
            root.right = tempRoot;
        }
    }
}