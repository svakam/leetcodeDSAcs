using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Strings
{
    class MinPartitions
    {
        // runtime: 560 ms, 5.29% faster
        // memory: 43.4 mb, 7.49% less
        public int MinPartitionsHashTable(string n)
        {
            // start a string with 0's, implement dictionaries for conversions, iterate through string and see if any chars don't match new string chars, if so, increment and return when equal
            int counter = 0;
            string counterAsString = new string('0', n.Length);
            Dictionary<char, int> convToInt = new Dictionary<char, int>
            {
                {'0', 0},
                {'1', 1},
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9}
            };
            Dictionary<int, char> convToChar = new Dictionary<int, char>()
            {
                {1, '1'},
                {2, '2'},
                {3, '3'},
                {4, '4'},
                {5, '5'},
                {6, '6'},
                {7, '7'},
                {8, '8'},
                {9, '9'}
            };
            while (counterAsString != n)
            {
                counter++;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] != counterAsString[i])
                    {
                        sb.Append(convToChar[convToInt[counterAsString[i]] + 1]);
                    }
                    else
                    {
                        sb.Append(counterAsString[i]);
                    }
                }
                counterAsString = sb.ToString();
            }
            return counter;
        }

        // above impl is longer than needs to be: the counter will just be the number of steps needed to increment to the highest char number
        public int MinPartitionsSimple(string n)
        {
            char highest = '0';
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > highest)
                {
                    highest = n[i];
                }
            }
            return int.Parse(highest.ToString());
        }
    }
}
