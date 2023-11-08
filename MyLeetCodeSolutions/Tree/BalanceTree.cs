using System.Data;
using myLeetCodeSolutions.String;

namespace MyLeetCodeSolutions.Tree;

public class BalanceTree
{
    /**
     * Action: check the height of the left and right subtree of a node to see
     * if it is balance.
     * A tree is balanced when it left and right subtrees are balance as well as
     * their subtrees
     */
    public bool IsBalancedTree(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);

        return Math.Abs(leftHeight - rightHeight) < 2 &&
               IsBalancedTree(root.left) &&
               IsBalancedTree(root.right);
    }

    private int GetHeight(TreeNode root)
    {
        if (root==null)
        {
            return 0;
        }

        return 1+ Math.Max(GetHeight(root.left), GetHeight(root.right));
    }

}