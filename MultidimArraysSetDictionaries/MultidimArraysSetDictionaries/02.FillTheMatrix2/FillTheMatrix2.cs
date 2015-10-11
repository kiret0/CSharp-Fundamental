using System;

class FillTheMatrix2
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = row;

        int[,] matrix = new int[row, col];
        int inputValue = 1;
        int rowCount = 0;
        for (int cols = 0; cols < col; cols++)
        {
            if (rowCount == 0)
            {
                while (rowCount <= row-1)
                {
                    matrix[rowCount, cols] = inputValue;
                    inputValue++;
                    rowCount++;
                }
            }
            else
            {
                while (rowCount > 0)
                {
                    rowCount--;
                    matrix[rowCount, cols] = inputValue;
                    inputValue++;
                    
                }
            }
        }

        for (int rows = 0; rows < row; rows++)
        {
            for (int cols = 0; cols < col; cols++)
            {
                Console.Write(matrix[rows,cols] + " ");
            }
            Console.WriteLine();
        }
    }
}
