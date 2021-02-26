using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.ArraysStrings
{
    // runtime: 456 ms, 100% faster
    // memory: 34.7 mb, 100% less
    class BoxOperations
    {
        public int[] MinOperations(string boxes)
        {
            // initialize new array
            // iterate over the boxes string
            // for an ith box, if the next box doesn't contain a ball, move on
            // if the next box contains a ball, add the distance between the two boxes to a counter
            // do this until all boxes are looked at
            // add counter to the new array

            int[] operationsPerBox = new int[boxes.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                for (int j = 0; j < boxes.Length; j++)
                {
                    if (j != i)
                    {
                        if (boxes[j] != '0')
                        {
                            operationsPerBox[i] += Math.Abs(i - j);
                        }
                    }
                }
            }
            return operationsPerBox;
        }
    }
}
