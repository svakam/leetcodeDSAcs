using System;
using System.Collections.Generic;
using System.Text;
using leetcodeDSAcs.Data_Structures;

namespace leetcodeDSAcs.Easy.LinkedList
{
    public class MergeTwoSortedLists
    {
        public Node Solution(Node l1, Node l2)
        {
            Node merged = new Node(-101); // dummy node
            Node curr = merged;

            while (l1 != null && l2 != null)
            {
                if (l1.Val <= l2.Val)
                {
                    curr.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    curr.Next = l2;
                    l2 = l2.Next;
                }
                curr = curr.Next;
            }

            if (l1 == null && l2 != null)
            {
                curr.Next = l2;
            }
            else
            {
                curr.Next = l1;
            }

            return merged.Next;
        }
    }
}
