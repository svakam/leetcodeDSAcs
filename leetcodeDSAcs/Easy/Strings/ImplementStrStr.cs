using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Strings
{
    class ImplementStrStr
    {
        // runtime exceeds limit for very large strings
        // memory: 37.59% better
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            if ((haystack.Length == 0 && needle.Length > 0) || (needle.Length > haystack.Length)) return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (IsNeedleInHaystack(haystack, needle, i))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public bool IsNeedleInHaystack(string haystack, string needle, int i)
        {
            for (int j = 1; j < needle.Length; j++)
            {
                if (i + 1 == haystack.Length) return false;
                if (needle[j] != haystack[i + 1])
                {
                    return false;
                }
                i++;
            }

            return true;
        }

        public int StrStrAlternative(string haystack, string needle)
        {
            // https://leetcode.com/problems/implement-strstr/discuss/1066884/c-kmp
            // https://leetcode.com/problems/implement-strstr/discuss/402189/C-Substring-Solution
        }
    }
}
