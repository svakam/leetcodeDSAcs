using leetcodeDSAcs.Data_Structures;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace leetcodeDSAcs.Medium.Trees
{
    internal class SymmetricTree
    {
        public static bool? IsSymmetric(TreeNode root)
        {
            if (root == null) throw new ArgumentNullException(nameof(root));

            // in a symmetric tree, each node's left and right must mirror the other side (node.left vs. node.right AND node.right vs. node.left must be same)

            return Helper(root.Left, root.Right);
        }

        public static bool Helper(TreeNode nodeA, TreeNode nodeB)
        {
            if (nodeA == null && nodeB == null) return true;
            if ((nodeA == null && nodeB != null) || (nodeA != null && nodeB == null)) return false;
            
            // node.left vs. node.right
            if (nodeA.Val == nodeB.Val)
            {
                return Helper(nodeA.Left, nodeB.Right) && Helper(nodeA.Right, nodeB.Left);
            }

            return false;
        }
    }
}

//           1
//       2       2
//     4           4
//      5         5
//     7 8       8 7