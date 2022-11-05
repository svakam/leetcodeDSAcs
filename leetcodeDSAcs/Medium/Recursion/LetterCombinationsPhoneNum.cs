using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Recursion
{
    public class LetterCombinationsPhoneNum
    {
        public static object Run(string digits)
        {
            if (digits.Length == 0) return null;

            Dictionary<char, char[]> letters = new Dictionary<char, char[]>();
            letters.Add('2', new char[] { 'a', 'b', 'c' });
            letters.Add('3', new char[] { 'd', 'e', 'f' });
            letters.Add('4', new char[] { 'g', 'h', 'i' });
            letters.Add('5', new char[] { 'j', 'k', 'l' });
            letters.Add('6', new char[] { 'm', 'n', 'o' });
            letters.Add('7', new char[] { 'p', 'q', 'r', 's' });
            letters.Add('8', new char[] { 't', 'u', 'v' });
            letters.Add('9', new char[] { 'w', 'x', 'y', 'z' });

            if (digits.Length == 1) return letters[digits[0]];

            //let recurse = function(i) {
            //        let downstreamResults
            //        let currResults
            //        if (!digits[i + 1]) {
            //    downstreamResults = map.get(digits[i])
            //            currResults = downstreamResults
            //        } else
            //{
            //    downstreamResults = recurse(i + 1)
            //            let currLetterArray = map.get(digits[i])
            //            currResults = []
            //            for (let i = 0; i < currLetterArray.length; i++)
            //    {
            //        let curr = currLetterArray[i]
            //                for (let j = 0; j < downstreamResults.length; j++)
            //        {
            //            let downstream = downstreamResults[j]
            //                    currResults.push(curr + downstream)
            //                }
            //    }
            //}
            //return currResults
            //    }

            //    return recurse(0)
            //};
        }

    }
}

// var letterCombinations = function(digits) {
//if (!digits) return []


// "29"
// i = 0, "2"
// i = 1, "9"
// i = 2, null -> return i = 1 combo ([w,x,y,z]) (result) to i = 0
// 2 = [a,b,c] combine with 1's array
// 2 -> [aw, ax, ay, az, bw, bx, by, bz, cw, cx, cy, cz]

// if digits[i + 1] doesn't exist, just return the digits[i]'s letter array as the result
// else combine digits[i]'s letter array and combine with downstream results and return overall results

// "29"
// recurse(0)
// downstreamResults = recurse(i + 1)
// recurse(i + 1)
// downstreamResults = ['w', 'x', 'y', 'z']
// return downstreamResults to recurse(0)
// currLetterArray = ['a', 'b', 'c']
// currResults = ["aw", "ax", "ay", "az", "bw", "bx, "by", "bz"]
// from 0 to 2
// i = 1
// curr = 'b'
// from 0 to 3
// j = 0
// downstream = 'w'