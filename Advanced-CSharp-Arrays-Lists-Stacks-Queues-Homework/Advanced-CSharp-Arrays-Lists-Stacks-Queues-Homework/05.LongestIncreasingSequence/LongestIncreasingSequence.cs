using System;
using System.Collections.Generic;
using System.Linq;


class LongestIncreasingSequence
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        List<int> numbers = new List<int>();
        List<int> currentSequence = new List<int>();
        List<int> longestSequence = new List<int>();

        int longestCount = 0;

        foreach (var number in input)
        {
            numbers.Add(number);
        }


    whileLoop:

        int i = 0;
        int currentCount = 0;
        currentSequence.Clear();
        while (numbers.Count != 0)
        {

        sequence:

            if (i + 1 == numbers.Count)
            {
                if (numbers.Count == 1)
                {
                    Console.WriteLine(numbers[numbers.Count - 1]);
                    break;
                }
                if (numbers[numbers.Count - 1] > numbers[numbers.Count - 2])
                {
                    currentSequence.Add(numbers[numbers.Count - 1]);
                    currentCount++;

                    Print(currentSequence);
                    numbers.Clear();
                    goto longestSequence;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(numbers[numbers.Count - 1]);
                    currentSequence.Clear();
                }
                if (currentCount > longestCount)
                {
                    longestCount = currentCount;
                    longestSequence.Clear();
                    longestSequence.InsertRange(0, currentSequence);
                }

            }
            else
            {
                if (numbers[i] < numbers[i + 1])
                {
                    currentSequence.Add(numbers[i]);
                    currentCount++;
                    i++;
                    goto sequence;
                }
                else if (numbers[i] > numbers[i + 1])
                {
                    currentSequence.Add(numbers[i]);
                    currentCount++;
                    numbers.RemoveRange(0, i + 1);
                    i++;
                    Print(currentSequence);
                    goto longestSequence; //End of current sequence
                }
                else
                {
                    currentSequence.Add(numbers[i]);
                    currentCount++;
                    numbers.RemoveRange(0, i + 1);
                    Print(currentSequence);
                    i++;
                }
            }
        longestSequence:

            if (currentCount > longestCount)
            {

                longestCount = currentCount;
                longestSequence.Clear();
                longestSequence.InsertRange(0, currentSequence);
            }
            goto whileLoop;
        } //End of while loop

        Console.Write("Longest: ");
        longestSequence.ForEach(p => Console.Write(p + " "));
        Console.WriteLine();
    }

    static void Print(List<int> list)
    {
        foreach (var number in list)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}