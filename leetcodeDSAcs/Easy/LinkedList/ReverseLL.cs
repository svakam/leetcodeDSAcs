using System;
using System.Collections.Generic;
using System.Text;
using leetcodeDSAcs.Data_Structures;

namespace leetcodeDSAcs.Easy.LinkedList
{
    // find repeatable pattern
    // run through algo fast, reorganize steps along the way and test
    // run from back to front (move in order of tracer to runner since it's a singly LL)
    // while condition should include a condition that breaks whatever is in the while loop at the correct point


    // runtime 88 ms, 89% faster
    // memory 25.1 mb, 62.91% less
    public class ReverseLL
    {
        public Node Solution(Node head)
        {
            // check for length 0 and 1
            if (head == null) return null;
            if (head.Next == null) return head;

            // initialize pointers
            Node tracer = head;
            Node curr = head.Next;
            Node runner = head.Next;

            while (curr != null) // only way this while loop can be broken is if curr ends on null
            {
                // set and reset pointers for appropriate reversal setup: tracer < curr < runner
                if (tracer == curr) curr = curr.Next;
                if (runner == curr) runner = runner.Next;

                // make the reversal and shift pointers up
                curr.Next = tracer;
                tracer = curr;
                curr = runner;
            }

            // remove beginning loop and return tracer
            head.Next = null;
            return tracer;
        }
    }
}
