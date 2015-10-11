using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", word);
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match matche in matches)
            {
                Console.WriteLine(matche.Groups[0]);
            }
        }
    }
