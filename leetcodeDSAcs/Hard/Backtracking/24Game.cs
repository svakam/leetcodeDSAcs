using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Hard.Backtracking
{
    public class _24Game
    {
        public static bool Run(int[] cards)
        {
            // division operations can return decimal values within acceptable margin of error
            List<double> list = new List<double>();
            foreach (int card in cards)
            {
                list.Add(card);
            }

            return CheckIfResultReached(list);
        }

        private static bool CheckIfResultReached(List<double> list)
        {
            // base case: if 1 item left, check if it's within 0.1 of 24
            if (list.Count == 1)
            {
                return Math.Abs(list[0] - 24) <= 0.1;
            }

            // recursive case:
            // get all possible combinations of numbers
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    // create new list to hold remaining numbers and a possible result number
                    List<double> newList = new List<double>();
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (k != i && k != j)
                        {
                            newList.Add(list[k]); 
                            // add all numbers to new list that aren't the two picked for the operations
                        }
                    }

                    // generate combos and iterate through to create new list of size previous array - 1
                    // will eventually become size 1 through recursion, at which point check if it's 24, else remove it
                    // take two numbers from list, perform all possible operations between them
                    List<double> combos = GeneratePossibleResults(list[i], list[j]);
                    foreach (double combo in combos)
                    {
                        // add it back to list, recurse on new list
                        newList.Add(combo);
                        if (CheckIfResultReached(newList))
                        {
                            return true;
                        }
                        // backtrack (remove result from list) if not 24
                        newList.Remove(newList.Count - 1);
                    }
                }
            }
            return false;
        }

        private static List<double> GeneratePossibleResults(double a, double b)
        {
            List<double> results = new List<double>();
            results.Add(a + b);
            results.Add(a - b);
            results.Add(b - a);
            results.Add(a * b);
            if (b != 0) results.Add(a / b);
            if (a != 0) results.Add(b / a);
            return results;
        }
    }
}

// [4,1,8,7]
// [4,1,8,7] -> [8,7], (5,3,-3,4,4,1/4)
// [8,7,5] -> [5], (15,1,-1,56,8/7,7/8)
// [5,15] -> [], (20,-10,10,75,5/15,3)
// [20] -> [-10] -> [10] -> [75] -> [5/15] -> [3] all false
