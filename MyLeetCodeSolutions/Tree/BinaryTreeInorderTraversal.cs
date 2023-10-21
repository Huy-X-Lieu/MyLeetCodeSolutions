namespace MyLeetCodeSolutions.Tree;

public class BinaryTreeInorderTraversal
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> valList = new List<int>();
        Helper(root,valList);
        return valList;

    }


    public void Helper(TreeNode root, List<int> list)
    {
        if (root != null)
        {
            Helper(root.left, list);
            list.Add(root.val);
            Helper(root.right, list);
        }
    }
}