using System;

namespace Reshape_the_Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Program.MatrixReshape(new int[1, 2, 3 , 3,4, 5 ], 2, 4));
        }


        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int[][] matrixReshape = new int[r][];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrixReshape[i][j] = mat[i][j];
                }
            }

            return matrixReshape;
        }
    }
}
