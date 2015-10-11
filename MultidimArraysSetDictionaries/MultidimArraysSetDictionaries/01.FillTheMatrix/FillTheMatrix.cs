using System;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int[,] matrix = new int[row, col];
        int inputValue = 1;
        for (int cols = 0; cols < col; cols++)
        {
            for (int rows = 0; rows < row; rows++, inputValue++ )
            {
                matrix[rows, cols] = inputValue;
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
