using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class WordCount
{
    static void Main()
    {
        var wordsData = new Dictionary<string, int>();
        List<string> list = new List<string>();
        using (StreamReader readWords = new StreamReader(@"../../word.txt"))
        using (StreamReader readText = new StreamReader(@"../../text.txt"))
        {
            string text;
            while ((text = readText.ReadLine()) != null)
            {
                string[] textArray = text.Split(new[] { ' ', ',', '.','-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var addText in textArray)
                {
                    list.Add(addText);
                }
            }
            string word;
            while ((word = readWords.ReadLine()) != null)
            {
                int count = 0;
                foreach (var wordTest in list)
                {
                    if (word.ToUpper().Equals(wordTest.ToUpper()))
                    {
                        count++;
                    }
                }
                wordsData.Add(word, count);
            }
            var sortedData = wordsData.OrderByDescending(a => a.Value);
            using(StreamWriter writeWords = new StreamWriter(@"../../results.txt"))
            {
                foreach (var outputWords in sortedData)
                {
                    writeWords.WriteLine(outputWords.Key + " - " + outputWords.Value);
                }
            }

        }
    }
}

