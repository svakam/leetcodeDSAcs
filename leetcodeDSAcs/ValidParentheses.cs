using System;
using System.Collections.Generic;

namespace leetcodeDSAcs
{
    // runtime: 76 ms, faster than 64.72%; memory: 21.7 MB, less than 69.98%
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            // instantiate stack class
            Stack stack = new Stack();

            // instantiate dictionary of related open/close brackets
            Dictionary<char, char> openBrackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Dictionary<char, char> closeBrackets = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            // iterate through string
            for (int i = 0; i < s.Length; i++)
            {
                // if open bracket is found, add to stack
                if (openBrackets.ContainsKey(s[i])) stack.Add(s[i]);
                // else if close bracket is found
                else
                {
                    Node top = stack.Peek();
                    // if top of stack is the opening of close bracket, remove top and move on, else validation failed and return false
                    if (top != null && top.Value == closeBrackets[s[i]]) stack.Remove();
                    else return false;
                }
            }

            return stack.Peek() == null;
        }
    }

    public class Stack
    {
        Node top;

        public void Add(char c)
        {
            Node n = new Node
            {
                Value = c,
                Next = null
            };

            if (top == null) top = n;
            else
            {
                n.Next = top;
                top = n;
            }
        }

        public Node Remove()
        {
            if (top == null) return null;
            Node temp = top;
            if (top.Next == null)
            {
                top = null;
                return temp;
            }

            temp = top;
            top = top.Next;
            temp.Next = null;
            return temp;
        }

        public Node Peek()
        {
            return top;
        }
    }

    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }
    }
}
