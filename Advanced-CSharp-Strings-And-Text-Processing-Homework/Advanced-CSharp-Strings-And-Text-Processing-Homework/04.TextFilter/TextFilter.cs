using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string[] changeWord = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string inputText = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
        StringBuilder text = new StringBuilder();
        text.Append(inputText);
        for (int i = 0; i < changeWord.Length; i++)
        {
            text.Replace(changeWord[i], new string('*', changeWord[i].Length));
        }
        Console.WriteLine(string.Join("",text));
    }
}
