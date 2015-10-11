using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnicodeChars
{
    static void Main()
    {
        string inputText = "Hi!";
        StringBuilder text = new StringBuilder();
        
        foreach (var symbol in inputText)
        {
            text.Append(@"\u");
            text.Append(String.Format("{0:x4}",(int)symbol));
        }
        Console.WriteLine(string.Join("",text));
    }
}

