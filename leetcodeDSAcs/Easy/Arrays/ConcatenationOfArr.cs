using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    // runtime: 240 ms, 94.78% faster
    // memory: 33.7 mb, 55% less
    class ConcatenationOfArr
    {
        public int[] GetConcatenation(int[] nums)
        {
            int length = nums.Length;
            int[] ans = new int[length * 2];
            bool flag = false;
            int n = 0;
            for (int i = 0; i < 2; i++)
            {
                if (flag)
                {
                    n += length;
                }
                for (int j = 0; j < nums.Length; j++)
                {
                    ans[j + n] = nums[j];
                }
                flag = true;
            }

            return ans;
        }
    }
}
