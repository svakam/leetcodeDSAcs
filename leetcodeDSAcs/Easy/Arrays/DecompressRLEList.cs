using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    public class DecompressRLEList
    {

        public static int[] Decompress(int[] nums)
        {
            // start linked list
            // iterate over array by 2 elements each
            // start an iteration over the value denoted by the 2nd element
            // add the 1st element to the linked list
            // start array of length of linked list
            // copy linkedlist to array
            // return array

            LinkedList<int> decompressed = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    decompressed.AddLast(nums[i + 1]);
                }
            }

            int[] decompressedArr = new int[decompressed.Count];
            decompressed.CopyTo(decompressedArr, 0);

            return decompressedArr;
        }
    }
}
