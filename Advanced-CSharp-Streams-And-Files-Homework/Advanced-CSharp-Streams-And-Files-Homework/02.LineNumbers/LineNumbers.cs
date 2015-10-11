using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"../../read.txt"))
        {
            StreamWriter writer = new StreamWriter(@"../../write.txt");
            string line;
            try {
                int lineNumber = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    writer.WriteLine(lineNumber + "." + line);
                    lineNumber++;
                }
            }
            finally
            {
                reader.Close();
                writer.Close();
            }
        }
    }
}
