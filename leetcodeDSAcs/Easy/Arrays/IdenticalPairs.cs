using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    class IdenticalPairs
    {
        // runtime: 84 ms, 93.86% faster
        // memory: 24.6 mb, 28.31% less
        public int NumIdenticalPairs(int[] nums)
        {
            // initialize counter set to 0
            // iterate over length of array
            // with a current element, iterate over the rest of the array
            // if current element equals another element in the array, increment counter
            // return counter

            int matches = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) matches++;
                }
            }
            return matches;
        }
    }
}
