using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Strings
{
    // runtime: 84 ms, 69.77% faster
    // memory: 23.2 mb, 65.73% faster
    class DefangIPAddr
    {
        public string DefangIPaddr(string address)
        {
            // initialize stringbuilder
            // iterate through input string
            // if char equals a dot, append a [, ., and ]
            // else add the same char to input
            // return string version of stringbuilder instance

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    sb.Append('[').Append('.').Append(']');
                }
                else
                {
                    sb.Append(address[i]);
                }
            }
            return sb.ToString();
        }
    }
}
