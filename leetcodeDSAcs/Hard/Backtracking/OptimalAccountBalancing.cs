using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Hard.Backtracking
{
    // given array of transactions where transactions[i] = [from^i, to^i, amount^i],
    // return minimum # transactions required to settle the debt (nobody owes others)

    public class LeetcodeSolution
    {
        public int Run(int[][] transactions)
        {
            int[] debt = BuildDebtArray(transactions);

            return GetMinTransfersAfter(0, debt);
        }

        private int GetMinTransfersAfter(int curId, int[] debt)
        {
            // if debt of this person is 0, move on
            while (curId < debt.Length && debt[curId] == 0)
            {
                curId++;
            }

            // if reached end of array, return 0
            if (curId == debt.Length)
            {
                return 0;
            }

            int minTransactions = int.MaxValue;
            for (int i = curId + 1; i < debt.Length; i++)
            {
                if (debt[i] * debt[curId] < 0) // if the product is negative, there is potential for transfer from currId to next id (i)
                {
                    debt[i] += debt[curId]; // transfer from currId to next id (i)
                    minTransactions = Math.Min(minTransactions, GetMinTransfersAfter(curId + 1, debt) + 1);
                    debt[i] -= debt[curId];
                }
            }

            return minTransactions;
        }

        private int[] BuildDebtArray(int[][] transactions)
        {
            Dictionary<int, int> debtMap = new Dictionary<int, int>();
            foreach (int[] transaction in transactions)
            {
                int donor = transaction[0];
                int recipient = transaction[1];
                int amount = transaction[2];

                if (!debtMap.ContainsKey(donor))
                {
                    debtMap.Add(donor, amount);
                }
                else
                {
                    debtMap[donor] += amount;
                }

                if (!debtMap.ContainsKey(recipient))
                {
                    debtMap.Add(recipient, amount * -1);
                }
                else
                {
                    debtMap[recipient] -= amount;
                }
            }

            int[] debt = new int[debtMap.Count];
            int i = 0;
            foreach (int amount in debtMap.Values)
            {
                debt[i++] = amount;
            }

            return debt;
            
        }
    }
}

// happy case: debts are settled after initial transactions
// [
// [1,2,5],[2,3,6],[3,2,1][3,1,5]
// ]

// recursive simple case: each id used at most once
// [
// [0,1,10],[1,0,1],[1,2,5],[2,0,5]
// ]
// 0 = $-4
// 1 = 4
// 2 = 0

// recursive edge case: using an id more than once
// [
// [2,5,1],[0,1,2],[0,3,1],[4,3,1]
// ]
// 0 = $-3
// 1 = $2
// 2 = $-1
// 3 = $2
// 4 = $-1
// 5 = $1

