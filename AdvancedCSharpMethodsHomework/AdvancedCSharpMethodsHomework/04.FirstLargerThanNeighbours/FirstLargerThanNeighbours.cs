using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };
        Console.WriteLine(GetIndexOfFirstLargerThanNeightbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstLargerThanNeightbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstLargerThanNeightbours(sequenceThree));
    }

    static int GetIndexOfFirstLargerThanNeightbours(int[] numbers)
    {
        int getIndex = 0;
        bool check = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                check = numbers[i] > numbers[i + 1];
            }
            else if (i == numbers.Length - 1)
            {
                check = numbers[i] > numbers[i - 1];
            }
            else
            {
                check = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];
            }
            if (check)
            {
                getIndex = i;
                return getIndex;
            }
            
        }
        return -1;
        
    }
}
