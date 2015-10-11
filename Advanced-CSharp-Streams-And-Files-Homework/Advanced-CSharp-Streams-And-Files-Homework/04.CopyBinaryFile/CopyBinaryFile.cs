using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class CopyBinaryFile
{
    private static string CatImagePath = "../../cat.jpg";
    private static string CatImagePathCopy = "../../catCopy.jpg";
    static void Main()
    {
        using (var source = new FileStream(CatImagePath,FileMode.Open))
        {
            using (var destination = new FileStream(CatImagePathCopy,FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    destination.Write(buffer, 0, readBytes);
                    
                }
            }
        }
    }
}
