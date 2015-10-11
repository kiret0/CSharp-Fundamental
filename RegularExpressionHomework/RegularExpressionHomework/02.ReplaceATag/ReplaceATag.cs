using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        string text = @"""<ul> <li> <a href=""http://softuni.bg"">SoftUni</a> </li> </ul>"" ";

        string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
        string replace = @"[URL href=$1]$2[/URL]";
        
        var replaced = Regex.Replace(text,pattern, replace);
        string patternTwo = @"[""]";
        string replaceTwo = @"";
        replaced = Regex.Replace(replaced, patternTwo, replaceTwo);
        Console.WriteLine(replaced);
    }
}

