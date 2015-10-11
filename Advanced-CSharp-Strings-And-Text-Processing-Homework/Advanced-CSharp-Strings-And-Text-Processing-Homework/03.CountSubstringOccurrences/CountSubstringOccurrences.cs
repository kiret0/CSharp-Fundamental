using System;
using System.Collections.Generic;
using System.Linq;

class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string testWord = Console.ReadLine();
        int counter = 0;
        for (int i = 0; i < text.Length - testWord.Length + 1; i++)
        {
            if (text.ToLower().Substring(i, testWord.Length).Equals(testWord.ToLower()))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
