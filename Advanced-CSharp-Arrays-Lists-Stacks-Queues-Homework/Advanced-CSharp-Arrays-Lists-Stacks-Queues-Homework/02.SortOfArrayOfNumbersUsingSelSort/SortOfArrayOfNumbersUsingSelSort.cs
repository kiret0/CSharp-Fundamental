using System;
using System.Collections.Generic;
using System.Linq;

class SortOfArrayOfNumbersUsingSelSort
{
    static void Main()
    {
        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int newInt = 0;

        for (int i = 0; i < inputArr.Length -1; i++)
        {
            for (int j = 0; j < inputArr.Length- 1; j++)
            {
                if (inputArr[j] > inputArr[j + 1])
                {
                    newInt = inputArr[j + 1];
                    inputArr[j + 1] = inputArr[j];
                    inputArr[j] = newInt;
                }
            }
        }
        Console.WriteLine(String.Join(" ",inputArr));
    }
}
