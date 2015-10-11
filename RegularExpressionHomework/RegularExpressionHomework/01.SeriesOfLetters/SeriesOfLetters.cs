using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern;
        string replace;
        Regex regex;
        for (int i = 0; i < text.Length; i++)
        {
            pattern = string.Format(@"{0}+", text[i]);
            replace = string.Format(@"{0}", text[i]);
            regex = new Regex(pattern);
            text = regex.Replace(text, replace);
        }
        Console.WriteLine(text);
    }
    

}

