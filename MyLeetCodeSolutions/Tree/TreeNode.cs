namespace MyLeetCodeSolutions.Tree;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class MyTreeFunctions
{
    public static TreeNode CreateTreeFromListOfInt(List<int> nums)
    {
        TreeNode root = new TreeNode(nums[0]);
        for(int i = 1; i < nums.Count; i++)
            Add(root, nums[i]);
        return root;
    }

    public static void Add(TreeNode root, int 
            num)
    {
        if (root.val < num)
        {
            if (root.right == null)
            {
                root.right = new TreeNode(num);
            }
            else
            {
                Add(root.right, num);
            }
        }

        if (root.val > num)
        {
            if (root.left == null)
            {
                root.left = new TreeNode(num);
            }
            else
            {
                Add(root.left, num);
            }
        }
    }
}