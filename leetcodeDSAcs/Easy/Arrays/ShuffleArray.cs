using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    class ShuffleArray
    {
        // runtime: 236 ms, 89.13% faster
        // memory: 33.2 mb, 32.83% less
        public int[] Shuffle(int[] nums, int n)
        {
            // instantiate new array of same length as input
            // iterate through half length of array
            // access ith element and add to ith element in new arr
            // access nth element and add to i+1th element in new arr
            // return new arr

            int[] arr = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                arr[j] = nums[i];
                arr[j + 1] = nums[n + i];
                j += 2; // needed a separate counter for the new array, since each array being accessed at different times
            }
            return arr;
        }
    }
}
