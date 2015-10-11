using System;
using System.Collections.Generic;
using System.Linq;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<string> inputList = new List<string>();
        for (int i = 0; i <input.Length; i++)
        {
            inputList.Add(input[i]);  
        }
        while (inputList.Any())
        {
            int counter = 0;
            string test = inputList[0];
            foreach (var word in inputList)
            {
                if (test == word)
                {
                    counter++;
                }
                
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write(test + " ");
            }
            Console.WriteLine();
            counter = 0;
            inputList.RemoveAll(p => p == test);
        }
    }
}
