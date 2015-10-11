using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindorms
{
    static void Main()
    {
        string[] inputText = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!','?' }, StringSplitOptions.RemoveEmptyEntries);
        char[] chars = new char[] { };
        SortedSet<string> palindromWords = new SortedSet<string>();
        foreach (var word in inputText)
        {
            chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversed = string.Join("",chars);
            if (reversed == word)
            {
                palindromWords.Add(word);
            }

        }

        Console.WriteLine(string.Join(",", palindromWords));
    }
}

