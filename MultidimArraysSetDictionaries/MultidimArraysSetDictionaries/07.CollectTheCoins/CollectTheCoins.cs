using System;
using System.Collections.Generic;
using System.Linq;

class CollectTheCoins
{
    static int currentRow = 0;
    static int currentCol = 0;
    
    static int coinsCount = 0;
    
    static void Main()
    {
        char[][] jaggedMatrix = new char[4][];

        // Input Matrix:
        for (int row = 0; row < 4; row++)
        {
            string inputLine = Console.ReadLine();
            jaggedMatrix[row] = new char[inputLine.Length];
            for (int col = 0; col < inputLine.Length; col++)
            {
                jaggedMatrix[row][col] = inputLine[col];
            }            
        }
        int wallCounter = 0;
        string input = Console.ReadLine();
        foreach (var symbol in input)
        {
            try
            {
                switch (symbol)
                {
                    case '<': currentCol--; CountCoins(jaggedMatrix); break;
                    case '>': currentCol++; CountCoins(jaggedMatrix); break;
                    case '^': currentRow--; CountCoins(jaggedMatrix); break;
                    case 'V': currentRow++; CountCoins(jaggedMatrix); break;
                }
            }
            catch(IndexOutOfRangeException)
            {
                wallCounter++;
                ReturnPosition(symbol);
            }
        }
        Console.WriteLine("Coins collected: {0}",coinsCount);
        Console.WriteLine("Walls hit: {0}",wallCounter);
        
    }
    static void ReturnPosition(char symbol)
    {
        switch (symbol)
        {
            case '<': currentCol++; break;
            case '>': currentCol--; break;
            case '^': currentRow++; break;
            case 'V': currentRow--; break;
        }
    }
    static void CountCoins(char[][] jaggedArray)
    {
    
        if (jaggedArray[currentRow][currentCol] == '$')
        {
            coinsCount++;
        }
    }
}
