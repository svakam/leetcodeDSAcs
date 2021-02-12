using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy
{
    // runtime: 236 ms, 75.55% faster
    // space: 31.6 mb, 18.45% smaller
    public class RunningSum1DArray
    {
        public int[] GetRunningSum(int[] nums)
        {
            // start sum variable
            // start sum array of the same length as nums array
            // iterate through input array
                // add value of element to sum
                // add value as new element of new array

            // return new array

            int sum = 0;
            int[] sumArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }
            return nums;
        }
    }
}
