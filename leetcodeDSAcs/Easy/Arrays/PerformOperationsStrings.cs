using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcodeDSAcs.Easy.Arrays
{
    public class PerformOperationsStrings
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            var mappingOperations = new Dictionary<string, int>()
            {
                {"++X", 1},
                {"X++", 1},
                {"X--", -1},
                {"--X", -1} // unnecessary
            };

            for (int i = 0; i < operations.Length; i++)
            {
                x += mappingOperations[operations[i]];
            }

            return x;
        }

        public int FinalValueAfterOperationsOneLiner(string[] operations) // needs linq library
        => operations.Sum(op => op.Contains('+') ? 1 : -1);
    }
}
