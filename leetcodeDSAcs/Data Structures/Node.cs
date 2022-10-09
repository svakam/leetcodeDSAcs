using System;
using System.Text;

namespace leetcodeDSAcs.Data_Structures
{
    public class Node
    {
        public int Val { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Val = val;
            Next = null;
        }

        public Node(int val, Node next) : this(val)
        {
            Next = next;
        }
    }
}
