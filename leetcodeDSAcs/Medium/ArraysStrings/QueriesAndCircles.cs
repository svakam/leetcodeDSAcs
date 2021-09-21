using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium
{
    public class QueriesAndCircles
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int numPointsInsideThisCircle = 0;

                for (int j = 0; j < points.Length; j++)
                {
                    if (IsPointInsideCircle(queries[i], points[j][0], points[j][1]))
                    {
                        numPointsInsideThisCircle++;
                    }
                }
                ans[i] = numPointsInsideThisCircle;
            }

            return ans;
        }

        public bool IsPointInsideCircle(int[] circle, int pointX, int pointY)
        {
            int centerX = circle[0];
            int centerY = circle[1];
            int radius = circle[2];

            if (Math.Pow(Math.Abs(centerX - pointX), 2) + Math.Pow(Math.Abs(centerY - pointY), 2) > Math.Pow(radius, 2))
            {
                return false;
            }
            return true;
        }
    }
}
