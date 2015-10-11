using System;
using System.Collections.Generic;
using System.Linq;
class MatrixShuffing
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] theMatrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                theMatrix[row, col] = Console.ReadLine();
            }
        }
        int xOne = 0;
        int yOne = 0;
        int xTwo = 0;
        int yTwo = 0;
        Console.WriteLine();
        string[] swap = Console.ReadLine().Split(' ');
        while (swap[0] != "END")
        {
            if (swap[0] != "swap" && swap.Length != 5)
            {
                Console.WriteLine("invalid Input!");
            }
            else
            {
                try
                {
                    xOne = int.Parse(swap[1]);
                    yOne = int.Parse(swap[2]);
                    xTwo = int.Parse(swap[3]);
                    yTwo = int.Parse(swap[4]);
                    string element = theMatrix[xOne, yOne];
                    theMatrix[xOne, yOne] = theMatrix[xTwo, yTwo];
                    theMatrix[xTwo, yTwo] = element;

                    PrintMatrix(rows,cols,theMatrix);
                }
                catch (SystemException)
                {
                    Console.WriteLine("Invalid Input!");
                }

            }
            Console.WriteLine();
            swap = Console.ReadLine().Split(' ');
        }
    }

    static void PrintMatrix(int rows,int cols,string[,] theMatrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(theMatrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
