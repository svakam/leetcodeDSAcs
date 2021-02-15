using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Modulo
{
    // runtime 56 ms, faster than 91.84% C# subs
    // memory 17.3 mb, less than 29.61% subs
    public class PalindromeNumber
    {
        // put digits into an array and read front->back and back-> front; if all match, return true, else false
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x <= 9) return true;

            int y = x;
            int numDigitsInInput = 0;
            while (y != 0)
            {
                y /= 10;
                numDigitsInInput++;
            }
            int[] digitsArray = new int[numDigitsInInput];
            for (int i = 0; i < digitsArray.Length; i++)
            {
                digitsArray[i] = x % 10;
                x /= 10;
            }
            int start = 0;
            int end = digitsArray.Length - 1;
            while (start != end && start < end)
            {
                if (digitsArray[start] != digitsArray[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }

    // other options:
    // revert initial number, then compare new number with old (problem: integer overflow with reversed number)
    // revert half of initial number (wait until input is less than output), compare new half with remainder of input
}
