using System;
using System.Collections.Generic;
using System.Linq;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = Math.Max(firstNumber, secondNumber);
        return max;
        
    }
}

