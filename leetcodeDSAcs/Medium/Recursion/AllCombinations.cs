using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Recursion
{
    public class AllCombinations
    {
        List<List<int>> Output { get; set; }
        List<int> S { get; set; }
        int[] Nums { get; set; }
        public List<List<int>> Run(int[] nums)
        {
            Nums = nums;
            if (nums.Length == 0) return null;
            Output = new List<List<int>>();
            
            for (int i = 0; i < Nums.Length; i++)
            {
                S.Add(Nums[i]);
                Output.Add(S);
                if (i < Nums.Length)
                {
                    Recurse(i + 1);
                }
                S.RemoveAt(S.Count - 1);
            }

            return Output;
        }

        private void Recurse(int i)
        {
            for (int j = i; j < Nums.Length; j++)
            {
                Console.WriteLine("hi" + j);                        
                S.Add(Nums[j]);
                PrintStack();
                Output.Add(S);
                PrintOutput();
            }
        }

        private void PrintStack()
        {
            for (int i = 0; i < S.Count; i++)
            {
                Console.WriteLine(S[i]);
            }
        }

        private void PrintOutput()
        {
            for (int i = 0; i < Output.Count; i++)
            {
                Console.Write($"i {i} : ");
                for (int j = 0; j < Output[i].Count; j++)
                {
                    Console.WriteLine(Output[i][j]);
                }
            }
        }
    }
}
