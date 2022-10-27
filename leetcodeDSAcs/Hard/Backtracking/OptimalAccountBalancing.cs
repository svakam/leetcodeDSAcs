using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Hard.Backtracking
{
    // given array of transactions where transactions[i] = [from^i, to^i, amount^i],
    // return minimum # transactions required to settle the debt (nobody owes others)
    public class OptimalAccountBalancing
    {
        public int MinTransfers(int[][] transactions)
        {
            // build balances across ids via transactions
            Dictionary<int, int> balances = new Dictionary<int, int>();
            for (int i = 0; i < transactions.Length; i++)
            {
                
            }

            // reiterate 
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

//   public int minTransfers(int[][] transactions) {
//int[] debt = buildDebtArray(transactions); // Debt amount to balance for each person.

//return getMinTransfersAfter(0, debt);
//    }
    
//    private int getMinTransfersAfter(int curId, int[] debt)
//{
//    while (curId < debt.length && debt[curId] == 0)
//        curId++;
//    // Base case.
//    if (curId == debt.length)
//        return 0;
//    // Recursive case.
//    int minTransactions = Integer.MAX_VALUE;
//    for (int i = curId + 1; i < debt.length; i++)
//    {
//        if (debt[i] * debt[curId] < 0)
//        {
//            debt[i] += debt[curId];
//            minTransactions = Math.min(minTransactions, getMinTransfersAfter(curId + 1, debt) + 1);
//            debt[i] -= debt[curId];
//        }
//    }

//    return minTransactions;
//}

//private int[] buildDebtArray(int[][] transactions)
//{
//    Map<Integer, Integer> debtMap = new HashMap<>(); // Map person ID to debt amount.

//    for (int[] transaction : transactions) {
//    int giver = transaction[0];
//    int taker = transaction[1];
//    int amount = transaction[2];
//    debtMap.put(giver, debtMap.getOrDefault(giver, 0) + amount);
//    debtMap.put(taker, debtMap.getOrDefault(taker, 0) - amount);
//}

//int[] debt = new int[debtMap.size()];
//int i = 0;
//for (int amount : debtMap.values())
//{
//    debt[i++] = amount;
//}

//return debt;
//    }