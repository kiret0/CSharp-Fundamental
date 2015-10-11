using System;
using System.Linq;

namespace _03.MaximalSum
{
    class MaximalSum
    {
        static int maxSum = int.MinValue;
        static int bestRow = 0;
        static int bestCol = 0;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);

            int[,] matrix = new int[row, col];
            
            for (int rows = 0; rows < row; rows++)
            {
                int[] splitInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < col; cols++)
                {

                    matrix[rows, cols] = splitInput[cols];
                }
            }

            int currentSum = 0;
            for (int rows = 0; rows < row - 2; rows++)
            {
                for (int cols = 0; cols < col - 2; cols++)
                {
                    currentSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2]
                        + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows+ 1, cols + 2]
                        + matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                    MaxSumMatrix(rows, cols, currentSum);
                }
            }
            Console.WriteLine("Sum = {0}",maxSum);
            PrintBiggestMatrix(bestRow, bestCol,matrix);

        }
        static void MaxSumMatrix(int rows,int cols,int currentSum)
        {

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                bestRow = rows;
                bestCol = cols;
            }
        }
        static void PrintBiggestMatrix(int rows,int cols,int[,] matrix)
        {
            for (int row = rows; row <= rows + 2; row++)
            {
                for (int col = cols ; col <= cols +2; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("{0} {1} {2} ", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            //Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            //Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        }
//1 5 5 2 4
//2 1 4 14 3
//3 7 11 2 8
//4 8 12 16 4
    }
    
}
