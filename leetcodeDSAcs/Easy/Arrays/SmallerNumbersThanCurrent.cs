using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    // runtime: 256 ms, 56.89% faster
    // memory: 32.4 mb, 72.26% less
    class SmallerNumbersThanCurrent
    {
        public int[] GetSmallerNumbersThanCurrent(int[] nums)
        {
            // initialize comparison array of same length as input array
            // iterate through array
            // initialize counter for each element
            // for each element, iterate through all elements of the array except current
            // if other element is smaller than current, increment counter
            // after iteration, add counter as element to new array
            // return array

            int[] comparison = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] > nums[j]) counter++;
                }
                comparison[i] = counter;
            }

            return comparison;
        }
    }
}
