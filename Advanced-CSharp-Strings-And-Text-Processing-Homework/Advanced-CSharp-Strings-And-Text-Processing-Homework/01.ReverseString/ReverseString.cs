using System;
using System.Collections.Generic;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        string name = "lirik";
        char[] letters = name.ToCharArray();
        string reverse = string.Join("", letters);
        Console.WriteLine(reverse);
    }
}

