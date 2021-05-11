using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Trees
{
    class FindCorrespondingNode
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {

            TreeNode currentClo = cloned;
            TreeNode result;

            // look at current node:
            if (currentClo == null) return null;
            Console.WriteLine(currentClo.val);
            if (currentClo.val == target.val) return currentClo;

            else
            {
                // go to left node
                result = GetTargetCopy(original, currentClo.left, target);
                if (result != null) return result;

                // go to right node
                result = GetTargetCopy(original, currentClo.right, target);
                if (result != null) return result;
            }
            return null;
        }
    }

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
    }
}
