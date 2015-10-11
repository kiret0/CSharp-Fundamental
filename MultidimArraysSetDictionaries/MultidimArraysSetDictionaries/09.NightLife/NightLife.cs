using System;
using System.Collections.Generic;
using System.Linq;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string,SortedSet<string>>> NightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        string city = "";
        string venue = "";
        string performars = "";
        string[] input = Console.ReadLine().Split(';');
        while (input[0] != "END")
        {
            city = input[0];
            venue = input[1];
            performars = input[2];
            if (!NightLife.ContainsKey(city))
            {
                NightLife[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!NightLife[city].ContainsKey(venue))
            {
                NightLife[city][venue] = new SortedSet<string>();
            }
            NightLife[city][venue].Add(performars);
            input = Console.ReadLine().Split(';');
        }
        foreach (var cityPair in NightLife)
        {
            Console.WriteLine(cityPair.Key);
            foreach (var venuePair in cityPair.Value)
            {
                Console.WriteLine("->{0}: {1}",venuePair.Key,String.Join(",",venuePair.Value));
            }
        }
        
    }
}

