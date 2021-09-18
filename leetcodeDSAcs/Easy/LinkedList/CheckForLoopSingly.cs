using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.LinkedList
{
    public class CheckForLoopSingly
    {
        public bool IsListALoop(ListNode head)
        {
            if (head == null) return false;
            if (head.next == head) return true;

            ListNode curr = head;
            ListNode runner = head;

            while (runner != null)
            {
                if (curr == runner)
                {
                    return true;
                }
                curr = curr.next;
                runner = runner.next.next; // Floyd's Cycle-Finding Algorithm: runner goes twice the speed of curr and WILL meet curr if LL has a loop
            }
            return false;
        }

    }
}
