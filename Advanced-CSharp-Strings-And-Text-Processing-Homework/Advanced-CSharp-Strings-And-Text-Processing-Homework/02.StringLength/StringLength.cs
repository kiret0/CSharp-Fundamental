using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringLength
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        StringBuilder text = new StringBuilder();
        text.Append(inputText);
        if (inputText.Length < 20)
        {
            for (int i = 0; i < (20 - inputText.Length); i++)
            {
                text.Append('*');
            }
            Console.WriteLine(string.Join("",text));
        }
        else
        {
            Console.WriteLine(inputText.Substring(0,20));
        }
        
    }
}

