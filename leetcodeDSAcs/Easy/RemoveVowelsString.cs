using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy
{
    class RemoveVowelsString
    {
        public string RemoveVowels(string s)
        {
            // initiate a string builder
            // iterate through the string char by char
            // if a char equals a, e, i, o, or u, move onto next char
            // else add it to string builder
            // finalize string builder to string and return it

            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    continue;
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
