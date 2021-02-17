using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    // runtime: 104 ms, 89.23% faster
    // space: 28.4 mb, 59.21% less
    class ShuffleString
    {
        public string Shuffle(string s, int[] indices)
        {
            // initialize char array of same length as indices array
            // iterate through input string
            // for each char, get index from indices array at same index as char and place that char into output char array
            // initialize string builder
            // iterate through char array
            // append chars from beginning to end to stringbuilder
            // return string version of stringbuilder

            char[] outputStr = new char[indices.Length];
            for (int i = 0; i < s.Length; i++)
            {
                outputStr[indices[i]] = s[i];
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in outputStr)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
