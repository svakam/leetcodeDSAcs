using System;
using System.Collections.Generic;
using System.Text;
using leetcodeDSAcs.Data_Structures;

namespace leetcodeDSAcs.Easy.LinkedList
{
    public class CheckForLoopSingly
    {
        public bool IsListALoop(Node head)
        {
            if (head == null) return false;
            if (head.Next == head) return true;

            Node curr = head;
            Node runner = head;

            while (runner != null)
            {
                if (curr == runner)
                {
                    return true;
                }
                curr = curr.Next;
                runner = runner.Next.Next; // Floyd's Cycle-Finding Algorithm: runner goes twice the speed of curr and WILL meet curr if LL has a loop
            }
            return false;
        }

    }
}
