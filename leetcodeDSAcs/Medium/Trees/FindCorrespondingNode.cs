using System;
using System.Collections.Generic;
using System.Text;
using leetcodeDSAcs.Data_Structures;

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
            Console.WriteLine(currentClo.Val);
            if (currentClo.Val == target.Val) return currentClo;

            else
            {
                // go to left node
                result = GetTargetCopy(original, currentClo.Left, target);
                if (result != null) return result;

                // go to right node
                result = GetTargetCopy(original, currentClo.Right, target);
                if (result != null) return result;
            }
            return null;
        }
    }
}
