using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace leetcodeDSAcs.Easy.Arrays
{
    // return true if array is monotone (always dec, always inc), else false
    // recursive impl
    public static class Monotone
    {
        public static bool Run(int[] arr)
        {
            if (arr.Length == 0) return false;
            if (arr.Length == 1) return true;

            int i = 0;
            while (arr[i + 1] == arr[i])
            {
                i++;
            }

            if (arr[i + 1] > arr[i])
            {
                return RecurseInc(arr, i);
            } 
            else
            {
                return RecurseDec(arr, i);
            }
        }

        private static bool RecurseInc(int[] arr, int i)
        {
            if (i == arr.Length)
            {
                return true;
            }
            else if (arr[i + 1] >= arr[i])
            {
                return RecurseInc(arr, i + 1);
            }
            else
            {
                return false;
            }
        }
        private static bool RecurseDec(int[] arr, int i)
        {
            if (i == arr.Length)
            {
                return true;
            }
            else if (arr[i + 1] <= arr[i])
            {
                return RecurseDec(arr, i + 1);
            }
            else
            {
                return false;
            }
        }
    }
}
