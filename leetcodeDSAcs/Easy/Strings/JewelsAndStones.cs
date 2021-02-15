using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Strings
{
    // runtime: 72 ms, 87.69% faster
    // memory: 24 mb, 32.77% faster
    class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            // initialize jewel counter set to 0
            // put all jewel characters into a hashset
            // iterate over stones string
            // if stones char equals chars in jewel hashset, increment counter
            // return counter

            int jewelCounter = 0;
            HashSet<char> jewelTypes = new HashSet<char>();
            foreach (char c in jewels)
            {
                jewelTypes.Add(c);
            }

            foreach (char c in stones)
            {
                if (jewelTypes.Contains(c)) jewelCounter++;
            }

            return jewelCounter;
        }
    }
}
