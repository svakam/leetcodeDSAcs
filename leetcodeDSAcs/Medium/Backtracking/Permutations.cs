using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Backtracking
{
    public class Permutations
    {
        //public int[][] Run(int[] nums)
        //{
        //    //for ()
        //}
    }
}

// [1,2,3]
// -> [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

// take index of first integer to consider as argument of backtrack(first)
// if first integer to consider has index n, current permutation is done
// else iterate over integers from first to n - 1
    // place ith integer first in permutation - swap(nums[first], nums[i])
    // create all permutations from ith integer with recursion backtrack(first + 1)
    // backtrack - swap(nums[first], nums[i]) back