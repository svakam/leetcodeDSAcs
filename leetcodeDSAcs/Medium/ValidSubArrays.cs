using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium
{
    public class ValidSubArrays
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                if (nums.Length == 0) return 0;
                if (nums[0] < k) return k;
                return 0;
            }
            if (k == 0) return 0;
            return GetNumOfSubArrays(0, 0, nums.Length - 1, 1, 0, nums, k);
            // 
        }

        public int GetNumOfSubArrays(int current, int beginning, int end, int currentProduct, int numOfValidSubArrays, int[] nums, int k)
        {
            if (nums[current] < k)
            {
                numOfValidSubArrays++;
                currentProduct *= nums[beginning];
                if 
            }
            GetNumOfSubArrays
        }
    }
}
