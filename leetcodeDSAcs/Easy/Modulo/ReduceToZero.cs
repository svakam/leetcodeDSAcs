using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Modulo
{
    // runtime: 36 ms, 91.10% faster
    // space: 15.3 mb, 36.18% less
    class ReduceToZero
    {
        public int NumberOfSteps(int num)
        {
            int steps = 0;
            while (num > 0)
            {
                if (num % 2 == 0) num /= 2;
                else num -= 1;
                steps++;
            }
            return steps;
        }
    }
}
