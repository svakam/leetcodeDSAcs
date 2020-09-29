using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs
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
            return GetNumOfSubArrays(0, nums.Length - 1, 1, 0, nums, k);
            // iterate through the array for i elements
            // if ith element is less than k, increment counter
            // else move to next element
            // do second iteration through array not including i for j elements
            // if i * j < k, increment counter and do nth iteration through array not including the past elements
            // else move to next element
            // return counter
        }

        public int GetNumOfSubArrays(int beginning, int end, int currentProduct, int numOfValidSubArrays, int[] nums, int k)
        {
            if (beginning < nums.Length)
            {
                if (nums[position] < k)
                {
                    numOfValidSubArrays++;
                    currentProduct = currentProduct * nums[position];
                }
                if (currentProduct < k)
                {
                    if (position != 0) numOfValidSubArrays++;
                    return GetNumOfSubArrays(beginning + 1, end, currentProduct, numOfValidSubArrays, nums, k);
                }
                else
                {
                    return GetNumOfSubArrays(beginning, end, 1, numOfValidSubArrays, nums, k);
                }
            }
            else
            {

                return numOfValidSubArrays;
            }
        }
    }
}
