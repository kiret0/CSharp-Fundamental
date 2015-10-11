using System;
using System.Collections.Generic;
using System.Linq;
//ha
//fifi
//ho
//hi
//fo
//ha
//hi
//xx
//xxx
//ho
//ha
//xx
class SequenceMatrix
{
    static int currentCount = 1;
    static int biggestCount = 0;
    static int rowsInput = int.Parse(Console.ReadLine());
    static int colsInput = int.Parse(Console.ReadLine());
    static string biggestWord;
    static void Main()
    {

        string[,] matrix = new string[rowsInput, colsInput];

        for (int row = 0; row < rowsInput; row++)
        {
            for (int col = 0; col < colsInput; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        for (int row = 0; row < rowsInput; row++)
        {
            for (int col = 0; col < colsInput; col++)
            {
                TestDiagonal(row, col, matrix);
                TestLine(row, col, matrix);
                TestColumn(row, col, matrix);
            }
        }
        for (int i = 0; i < biggestCount; i++)
        {
            if (i == biggestCount -1)
            {
                Console.WriteLine("{0}",biggestWord);
            }
            else
            {
                Console.Write("{0}, ", biggestWord);
            }
            
        }

    }

    static void TestColumn(int rows, int cols, string[,] matrix)
    {
        for (int row = rows,col = cols; row < rowsInput -1 && col < colsInput; row++)
        {
            if (matrix[row,col] == matrix[row + 1,col])
            {
                currentCount++;
            }
            FoundBestWord(matrix,row,col);
        }
        currentCount = 1;
    }

    static void TestLine(int rows,int cols,string[,] matrix)
    {
        for (int row = rows,col = cols; row < rowsInput && col < colsInput -1; col++)
        {
            if (matrix[row,col] == matrix[row,col+1])
            {
                currentCount++;
            }
            FoundBestWord(matrix, row, col);
        }
        currentCount = 1;
    }

    static void TestDiagonal(int rows, int cols, string[,] matrix)
    {
        for (int row = rows, col = cols; row < rowsInput - 1 && col < colsInput - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentCount++;
            }
            FoundBestWord(matrix, row, col);
        }
        currentCount = 1;
    }

    static void FoundBestWord(string[,] matrix, int row, int col)
    {
        if (currentCount > biggestCount)
        {
            biggestCount = currentCount;

            biggestWord = matrix[row, col];
        }
    }
}
