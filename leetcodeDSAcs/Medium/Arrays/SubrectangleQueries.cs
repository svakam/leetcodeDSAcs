using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Arrays
{
    // runtime and memory differences negligible, since solution is so simple
    public class SubrectangleQueries
    {
        int[][] Rectangle { get; set; }

        public SubrectangleQueries(int[][] rectangle)
        {
            Rectangle = rectangle;
        }

        // premise will be to iterate from starting coordinate all the way to end coordinate and replace every value with newValue
        // iterate over subarrays by lower bound row1 and upper bound row2
        // iterate over columns by lower bound col1 and upper bound col2
        // replace current with new value
        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    Rectangle[i][j] = newValue; 
                }
            }
        }

        public int GetValue(int row, int col)
        {
            return Rectangle[row][col];
        }
    }

    /**
     * Your SubrectangleQueries object will be instantiated and called as such:
     * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
     * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
     * int param_2 = obj.GetValue(row,col);
     */
}
