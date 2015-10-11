using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        using (StreamReader reader = new StreamReader(@"../../ReadMe.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(list[i]);
                }
            }
            reader.Close();
        }
    }
}