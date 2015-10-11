using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers,i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool check = false;
        if (i == 0)
        {
            check = numbers[i] < numbers[i + 1];
        }
        else if(i == numbers.Length - 1)
        {
            check = numbers[i] < numbers[i - 1];
        }
        else
        {
            check = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];
        }
        return check;
    }
}

