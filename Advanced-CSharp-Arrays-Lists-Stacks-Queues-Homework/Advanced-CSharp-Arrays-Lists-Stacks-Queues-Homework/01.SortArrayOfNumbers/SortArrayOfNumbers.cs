using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(inputArr);
        Console.WriteLine(String.Join(" ",inputArr));
    }
}
