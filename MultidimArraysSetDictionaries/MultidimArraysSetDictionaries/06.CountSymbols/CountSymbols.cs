using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        List<char> symbols = new List<char>();
        SortedDictionary<char, int> storage = new SortedDictionary<char, int>();
        int count = 0;
        
        foreach  (char symbol in inputText)
        {
            symbols.Add(symbol);
        }

        while (symbols.Any())
        {
            char testChar = symbols[0];
            foreach (char symbol in symbols)
            {
                if (symbol == testChar)
                {
                    count++;
                }
            }
            storage.Add(testChar, count);
            symbols.RemoveAll(p => p == testChar);
            count = 0;
        }
        foreach (var printSymbol in storage)
        {
            Console.WriteLine("{0}: {1} time/s",printSymbol.Key,printSymbol.Value);
        }
    }

}
