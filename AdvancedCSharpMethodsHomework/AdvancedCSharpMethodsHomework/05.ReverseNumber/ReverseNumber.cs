using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();
        double reverse = GetReversedNumber(inputNumber);
        Console.WriteLine(reverse);
    }

    static double GetReversedNumber(string nums)
    {
        char[] numsArray = nums.ToCharArray();
        Array.Reverse(numsArray);
        nums = String.Join("",numsArray);
        double v = double.Parse(nums);
        return v;
    }
}
