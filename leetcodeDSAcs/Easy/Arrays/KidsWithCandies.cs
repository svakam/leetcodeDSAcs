using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    class KidsWithCandies
    {
        // runtime: 236 ms, faster than 78.06%
        // memory: 31.2 mb, less than 83.01%
        public IList<bool> GetGreatestCandiesOfEachKid(int[] candies, int extraCandies)
        {
            // initialize bool array of same length as candies array

            // determine what the greatest value in the array is:
            // initialize max variable to 0
            // iterate through the array
            // if an element is greater than max, reassign max to that element

            // iterate through the array
            // add extra candies to element
            // if new value of element is greater than or equal to max, set same iteration of element in bool array to true
            // else set same iteration of bool array to false

            bool[] doKidsHaveGreatestCandies = new bool[candies.Length];
            int maxCandies = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > maxCandies) maxCandies = candies[i];
            }

            for (int i = 0; i < candies.Length; i++)
            {
                candies[i] += extraCandies;
                doKidsHaveGreatestCandies[i] = candies[i] >= maxCandies; 
                // if candies[i] is greater than or equal to max candies, set bool array[i] to true, else false
                // simpler than writing doKidsHaveGreatestCandies[i] = candies[i] >=maxCandies ? true : false;
            }

            return doKidsHaveGreatestCandies;
        }
    }
}
