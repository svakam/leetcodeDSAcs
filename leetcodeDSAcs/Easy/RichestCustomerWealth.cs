using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy
{
    // runtime: 100 ms, faster than 43.06%
    // memory: 25.4 mb, less than 88.63%
    class RichestCustomerWealth
    {
        public int GetMaximumWealth(int[][] accounts)
        {
            // initialize biggest sum variable to 0
            // iterate through each subarray
            // initialize counter for subarray sum to 0
            // per subarray, add elements to counter
            // if counter is larger than max sum
            // reassign counter to the max sum
            // return biggest sum

            int biggestSum = 0; // biggest sum should be outside all iteration
            
            for (int i = 0; i < accounts.Length; i++)
            {
                int subArraySum = 0; // subarray counter should be within subarray iteration
                for (int j = 0; j < accounts[i].Length; j++) // remember to get length of subarray
                {
                    subArraySum += accounts[i][j];
                }
                if (subArraySum > biggestSum)
                {
                    biggestSum = subArraySum;
                }
            }
            return biggestSum;
        }
    }
}
