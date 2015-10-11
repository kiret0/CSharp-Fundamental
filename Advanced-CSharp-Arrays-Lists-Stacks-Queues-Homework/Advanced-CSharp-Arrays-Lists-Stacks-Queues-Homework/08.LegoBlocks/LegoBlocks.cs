using System;
using System.Linq;


class LegoBlocks
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[number][];
        int[][] jaggedArray2 = new int[number][];


        Input(jaggedArray, number);
        Input(jaggedArray2, number);


        //Comparison
        Array.Reverse(jaggedArray2[0]);
        for (int i = 0; i < number - 1; i++)
        {
            if (jaggedArray[i].Length + jaggedArray2[i].Length == jaggedArray[i + 1].Length + jaggedArray2[i + 1].Length)
            {
                Array.Reverse(jaggedArray2[i + 1]);
            }
            else
            {
                CalcCellCount(jaggedArray, jaggedArray2, number);
                return;
            }
        }
        //Arrays fit - print
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("[" + String.Join(", ", jaggedArray[i]) + ", " + String.Join(", ", jaggedArray2[i]) + "]");
        }
    }


    static int[][] Input(int[][] jaggedArr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            jaggedArr[i] = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

        }
        return jaggedArr;
    }


    //Arrays do not fit - print number of cells
    static void CalcCellCount(int[][] jaggedArr, int[][] jaggedArr2, int input)
    {
        int cellsCount = 0;
        for (int i = 0; i < input; i++)
        {
            cellsCount += (jaggedArr[i].Length + jaggedArr2[i].Length);
        }
        Console.WriteLine("The total number of cells is: {0}", cellsCount);
    }


}
