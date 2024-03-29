﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Arrays
{
    public class SpiralMatrix
    {
        // return clockwise spiral
        public IList<int> Run(int[][] matrix)
        {
            List<int> output = new List<int>();
            int row = 0, col = 0, lb = -1, tb = -1, rb = matrix[0].Length, bb = matrix.Length;

            bool withinBoundaries = true;
            while (withinBoundaries)
            {
                // move right
                if (col == rb) withinBoundaries = false;
                while (withinBoundaries && col < rb)
                {
                    output.Add(matrix[row][col]);
                    col++;
                }
                row++;
                rb--;

                // move down
                if (row == bb) withinBoundaries = false;
                while (withinBoundaries && row < rb)
                {
                    output.Add(matrix[row][col]);
                    row++;
                }
                col--;
                bb--;

                // move left
                if (col == lb) withinBoundaries = false;
                while (withinBoundaries && col > lb)
                {
                    output.Add(matrix[row][col]);
                    col--;
                }
                row--;
                lb++;

                // move up
                if (row == tb) withinBoundaries = false;
                while (withinBoundaries && col > lb)
                {
                    output.Add(matrix[row][col]);
                    row--;
                }
                col++;
                tb++;
            }

            return output;
        }
    }
}

//   j
// [[1,2,3],i
//  [4,5,6],
//  [7,8,9]] // -> [1,2,3,6,9,8,7,4,5,6]

//   j
// [[1,2,3,4,5],i
//  [6,7,8,9,1],
//  [2,3,4,5,6]] -> [1,2,3,4,5,1,6,5,4,3,2,6,7,8,9,1]

// while curr element still has room to move (i.e. when switches direction, does not cross a boundary)
// 1. j++ until right boundary rb
// 2. tb++
// 3. i++ until bottom boundary bb
// 4. rb--
// 5. j-- until left boundary lb
// 6. bb--
// 7. i-- until top boundary tb
// 8. lb++
