using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z](?:\.[a-z]+)+)\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match email in matches)
        {
            Console.WriteLine(email.Groups[0]);
        }
    }
}

