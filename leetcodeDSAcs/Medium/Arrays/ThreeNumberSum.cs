using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Arrays
{
    // given an array of distinct integers, return all possible triplets in the array that sum up to a target value
    // [ 2,3,4,11,0,-2,5], 9 -> [[2,3,4],[-2,0,11]]
    // [-2,0,2,3,4,5,11]
    //    i  j              k

    public class ThreeNumberSum
    {
        public static LinkedList<int[]> Run(int[] arr, int target)
        {
            if (arr.Length < 3) return null;
            LinkedList<int[]> triplets = new LinkedList<int[]>();

            // sort the array

            // iterate over i elements
                // set up 3 pointers on the array and check combinations with ith element until a triplet equals target
                // increment left pointer when sum needs to be greater
                // decrement right pointer when sum needs to be smaller

            int n = arr.Length;
            for (int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;

                while (left < right)
                {
                    int currSum = arr[i] + arr[left] + arr[right];
                    if (currSum < target)
                    {
                        left++;
                    }
                    else if (currSum > target)
                    {
                        right--;
                    }
                    else
                    {
                        int[] triplet = new int[] { arr[i], arr[left], arr[right] };
                        triplets.AddLast(triplet);
                        left++;
                        right--;
                    }
                }
            }
            return triplets;
        }
    }
}
