using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    // runtime 88 ms, 89% faster
    // memory 25.1 mb, 62.91% less
    public class Solution
    {
        public ListNode ReverseLL(ListNode head)
        {
            // check for length 0 and 1
            if (head == null) return null;
            if (head.next == null) return head;

            // initialize pointers
            ListNode tracer = head;
            ListNode curr = head.next;
            ListNode runner = head.next;

            while (curr != null) // only way this while loop can be broken is if curr ends on null
            {
                // set and reset pointers for appropriate reversal setup: tracer < curr < runner
                if (tracer == curr) curr = curr.next;
                if (runner == curr) runner = runner.next;

                // make the reversal and shift pointers up
                curr.next = tracer;
                tracer = curr;
                curr = runner;
            }

            // remove beginning loop and return tracer
            head.next = null;
            return tracer;
        }
    }
}
