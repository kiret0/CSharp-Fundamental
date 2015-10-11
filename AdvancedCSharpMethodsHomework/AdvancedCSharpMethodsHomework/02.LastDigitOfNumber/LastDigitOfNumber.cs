using System;
using System.Collections.Generic;
using System.Linq;

class LastDigitOfNumber
{
    static void Main()
    {
        Console.WriteLine(GetLastDigitAsWord(512));
        Console.WriteLine(GetLastDigitAsWord(1024));
        Console.WriteLine(GetLastDigitAsWord(12309));
    }

    static string GetLastDigitAsWord(int lastDigit)
    {
        int returnLastDigit = lastDigit % 10;
        string changeLastDigit = "";
        switch (returnLastDigit)
        {
            case 0: return changeLastDigit = "zero";
            case 1: return changeLastDigit = "one";
            case 2: return changeLastDigit = "two";
            case 3: return changeLastDigit = "three";
            case 4: return changeLastDigit = "four";
            case 5: return changeLastDigit = "five";
            case 6: return changeLastDigit = "six";
            case 7: return changeLastDigit = "seven";
            case 8: return changeLastDigit = "eight";
            case 9: return changeLastDigit = "nine";
        }
        return changeLastDigit;
    }
}
