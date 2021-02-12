using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int final = 0;
            Dictionary<char, int> symbolValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            Dictionary<char, char[]> subtractions = new Dictionary<char, char[]>()
            {
                {'I', new char[]{'V', 'X' } },
                {'X', new char[]{'L', 'C' } },
                { 'C', new char[]{'D', 'M' } }
            };
            for (int i = 0; i<s.Length; i++)
            {
                if (subtractions.ContainsKey(s[i]))
                {
                    if ((i + 1) <= s.Length - 1)
                    {
                        for (int j = 0; j< 2; j++)
                        {
                            if (s[i + 1].Equals(subtractions[s[i]][j]))
                            {
                                int temp = symbolValues[s[i + 1]] - symbolValues[s[i]];
                                final += temp;
                            }
                        }
                        i++;
                    }
                }
                else
                {
                    final += symbolValues[s[i]];
                }
            }
        
            return final;
        }
    }
}
