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