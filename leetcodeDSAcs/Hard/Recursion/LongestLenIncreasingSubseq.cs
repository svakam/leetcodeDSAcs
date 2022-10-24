using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Hard.Recursion
{
    public class LongestLenIncreasingSubseq
    {

        public int Run(int[] input)
        {
            Dictionary<int, List<int[]>> dict = new Dictionary<int, List<int[]>>();

            for (int i = 0; i < input.Length; i++)
            {
                List<int[]> combos;
                if (i < input.Length)
                {
                    combos = GetCombos(dict, input, i); // e.g. 4 = [[4]]; 3 = [[3],[3,4]]; 2 = [[2],[2,4]]
                    foreach (int[] combo in combos)
                    {
                        
                    }
                }
                else
                {
                    combos = new List<int[]>();
                    combos.Add(new int[] { input[i] });
                    
                }
            }
        }

        public List<int[]> GetCombos(Dictionary<int, List<int[]>> dict, int[] input, int i)
        {
            if (i < input.Length)
            {
                List<int[]> combos = GetCombos(dict, input, i);

            }
        }
    }
}

// [1,3,2,4] -> [4],[2],[2,4],[3],[3,4],[1],[1,2,4],[1,3,4] -> 3
// [2,1,4,3,5,7,8] -> [8],[7],[7,8],[5],[5,8],[5,7],[5,7,8],[3],[3,5,8],[3,5,7],[3,5,7,8],
// [4],[4,5],[4,5,7],[4,5,7,8],[1],[1,4],[1,4,5],[1,4,5,7],[1,4,5,7,8],[1,3],[1,3,5],[1,3,5,7],
// [1,3,5,7,8],[2],[2,3],[2,3,5],[2,3,5,7],[2,3,5,7,8]

// k     v
// 4     [4]
// 2     [2,4]
// 3     [3,4]
// 1     [1,2,4],[1,3,4]
// if input[i] less any key in dict, prepend it to all arrays key's array list and add it as value
