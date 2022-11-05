using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Arrays
{
    public static class FindMinMax
    {
        public static int Run(int[] arr, MinMax type)
        {
            if (type == MinMax.GetMax)
            {
                return GetMax(arr, 0, 0);
            }
            else
            {
                return GetMin(arr, 0, 0);
            }
        }

        private static int GetMin(int[] arr, int i, int minIdx)
        {
            if (i + 1 == arr.Length) return minIdx;
            else
            {
                if (arr[i + 1] < arr[i]) return GetMin(arr, i + 1, i + 1);
                else return GetMin(arr, i + 1, minIdx);
            }
        }

        private static int GetMax(int[] arr, int i, int maxIdx)
        {
            if (i + 1 == arr.Length) return maxIdx;
            else
            {
                if (arr[i + 1] > arr[i]) return GetMax(arr, i + 1, i + 1);
                else return GetMax(arr, i + 1, maxIdx);
            }
        }
    }

    public enum MinMax
    {
        GetMin,
        GetMax
    }
}
