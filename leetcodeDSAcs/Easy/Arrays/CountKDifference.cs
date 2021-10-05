using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    // brute force runtime 100 ms, 84.85% faster (O(n^2))
    // memory 26.4 mb, 42.42% less
    public class CountKDifference
    {
        public int Solution(int[] nums, int k)
        {
            if (nums.Length == 1) return 0;
            if (nums.Length == 2 && Math.Abs(nums[0] - nums[1]) == k) return 1;
            else if (nums.Length == 2) return 0;

            int validPairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        validPairs++;
                    }
                }
            }
            return validPairs;
        }

        // frequency dictionary: O(n)
        public int FreqDictionary(int[] nums, int k)
        {
            var freq = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //if (!freq.TryAdd(nums[i], 1)) freq[nums[i]]++;
            }

            int count = 0;
            foreach (var kvp in freq)
            {
                int test = kvp.Key + k;
                if (freq.ContainsKey(test))
                {
                    count += kvp.Value * freq[test];
                }
            }

            return count;
        }
    }
}
