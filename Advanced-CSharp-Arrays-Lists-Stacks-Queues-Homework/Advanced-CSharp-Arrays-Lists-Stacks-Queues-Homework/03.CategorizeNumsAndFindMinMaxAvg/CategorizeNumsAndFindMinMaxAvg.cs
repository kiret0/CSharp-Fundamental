using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumsAndFindMinMaxAvg
{
    static void Main()
    {
        double[] inputArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        List<double> doubleArr = new List<double>();
        List<double> roundNums = new List<double>();
        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i] % 1 == 0 )
            {
                roundNums.Add(inputArr[i]);
            }
            else
            {
                doubleArr.Add(inputArr[i]);
            }
        }
        double max = doubleArr.Max();
        double min = doubleArr.Min();
        double sum = doubleArr.Sum();
        double avg = doubleArr.Average();
        
        Console.WriteLine("[" + String.Join(" ",doubleArr ) + "]" + "->" + "min: {0}, max: {1}, sum: {2}, avg: {3:f2}",min,max,sum,avg);

        double max1 = roundNums.Max();
        double min1 = roundNums.Min();
        double sum1 = roundNums.Sum();
        double avg1 = roundNums.Average();

        Console.WriteLine("[" + String.Join(" ", roundNums) + "]" + "->" + "min: {0}, max: {1}, sum: {2}, avg: {3:f2}", min1, max1, sum1, avg1);
    }
}
