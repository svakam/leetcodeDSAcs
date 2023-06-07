using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace leetcodeDSAcs.Medium.Strings
{
    public class FirstNonRepeat
    {
        public static void Run()
        {
            GetFirstNonRepeat(""); // exception
            GetFirstNonRepeat("s"); // s
            GetFirstNonRepeat("abcdef"); // a
            GetFirstNonRepeat("abccba"); // null
            string a = "the faint red box shelters a fox that dances in the woods at night under the bright starry lights.";
            GetFirstNonRepeat(a);
        }

        private static char? GetFirstNonRepeat(string s)
        {
            if (s.Length == 0) throw new ArgumentNullException("Did not provide a string");
            if (s.Length == 1) return s[0];

            // hashtable of repeated vs. nonrepeated chars
            Dictionary<char, bool> charsRepeated = new Dictionary<char, bool>();

            for (int currChar = 0; currChar < s.Length; currChar++)
            {
                if (charsRepeated.ContainsKey(s[currChar]))
                {
                    charsRepeated.Add(s[currChar], false);
                }
                else
                {
                    charsRepeated[s[currChar]] = true;
                }
            }

            // enumerate through hashtable to find first char with false as value and return that char
            foreach (KeyValuePair<char, bool> charRepeat in charsRepeated)
            {
                if (charRepeat.Value == true)
                {
                    return charRepeat.Key;
                }
            }

            return null;
        }
    }

}

// the fain rd box sl c  
// the fain rd  ox s