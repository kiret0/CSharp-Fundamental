using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSum
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> list = new List<int>();

        int allCombinations = 1 << input.Length;

        for (int i = 0; i < allCombinations; i++)
        {
            int position = input.Length - 1;
            int bitMask = i;

            while (bitMask > 0)
            {
                if ((bitMask & 1) == 1)
                {
                    list.Add(input[position]);
                }
                bitMask >>= 1;
                position--;
            }
            if (list.Sum() == inputNumber)
            {
                Console.WriteLine("{0} = {1}", String.Join(" + ", list), inputNumber);
            }
            list.Clear();
        }
    }
}
