using System.Runtime.CompilerServices;

namespace MyLeetCodeSolutions.Tree;

public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        return Helper(root.right, root.left);
    }
    

    private bool Helper(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null ^ q == null)
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        return Helper(p.left, q.right) && Helper(p.right, q.left);
    }
}