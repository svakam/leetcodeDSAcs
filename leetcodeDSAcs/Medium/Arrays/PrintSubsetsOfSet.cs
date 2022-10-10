using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Arrays
{
    // number of subsets = 2^n, n = number of elements in input
        // should include nth element in current subset or not?
        // for each item arr[n], there are two available choices (to include or not to include), thus 2^n
    public class PrintSubsetsOfSet
    {
        public LinkedList<int[]> Output { get; set; }
        public PrintSubsetsOfSet()
        {
            Output = new LinkedList<int[]>();
        }
        public void Run(int[] arr)
        {
            int[] subset = new int[arr.Length];
            Helper(arr, subset, 0);
        }

        private void Helper(int[] arr, int[] subset, int i)
        {
            Console.WriteLine(subset.ToString());
            // base case: if i exceeds arr length
            if (i == arr.Length)
            {
                Output.AddLast(subset);
                return;
            }
            // recursion: include current elem or exclude
            Helper(arr, subset, i++);
            subset[i] = arr[i];
            Helper(arr, subset, i++);
        }
    }
}
// [,,]
