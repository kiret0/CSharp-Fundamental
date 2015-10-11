using System;
using System.Collections.Generic;
using System.Linq;

    class Phonebook
    {
        static void Main()
        {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string[] inputLine = Console.ReadLine().Split('-');
        while (inputLine[0] != "search")
        {
            phonebook.Add(inputLine[0], inputLine[1]);
            inputLine = Console.ReadLine().Split('-');
        }
        string inputName = Console.ReadLine(); 
        while(!String.IsNullOrEmpty(inputName))
        {
            if (phonebook.ContainsKey(inputName))
            {
                foreach (var name in phonebook)
                {
                    Console.WriteLine($"{name.Key} -> {name.Value}");
                }
            }
            else
            {
                Console.WriteLine($"Contact {inputName} does not exist.");
                
            }
            inputName = Console.ReadLine();
        }
        
        }
    }
