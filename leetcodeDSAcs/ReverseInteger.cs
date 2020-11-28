using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs
{
    // runtime: 40 ms, faster than 80.31% c# subs
    // space: 15.8 mb, less than 18.98% subs
    // attempted incorrectly b4 in java
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x > -10 && x < 10) return x;

            // if negative, convert to positive for time being
            bool isNegative = false;
            if (x < 0)
            {
                isNegative = true;
                x *= -1;
            }

            // get number of digits
            int numDigits = (int)Math.Floor(Math.Log10(x) + 1);

            // start counter for power incrementation
            int power = numDigits - 1;
            // start new integer
            int newInt = 0;
            // while input is not 0
            while (x != 0)
            {
                // get end integer by modulo and add it to new integer via power incrementing
                try
                {
                    checked
                    {
                        newInt = newInt + (x % 10) * (int)Math.Pow(10, power);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex);
                    return 0;
                }
                power--;
                // remove end integer by division
                x /= 10;
            }

            // add back negative if needed
            if (isNegative)
            {
                newInt *= -1;
            }

            return newInt;
        }
    }
}
