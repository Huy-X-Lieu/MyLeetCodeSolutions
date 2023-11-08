namespace MyLeetCodeSolutions.Tree;

public class SortedArrayToBST
{
    public TreeNode ConvertSortedArrayToBST(int[] nums)
    {
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        int pivot = (right + left) / 2;
        
        TreeNode root = new TreeNode(nums[pivot]);
        root.left     = Helper(nums, left, pivot - 1);
        root.right = Helper(nums, pivot + 1, right);
        return root;
    }
}