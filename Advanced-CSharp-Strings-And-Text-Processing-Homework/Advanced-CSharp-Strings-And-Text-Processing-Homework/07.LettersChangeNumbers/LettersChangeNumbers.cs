using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class LettersChangeNumbers
{
    static void Main()
    {
        string inputText = Console.ReadLine().Trim();
        string patterns = @"\s+";
        string[] splitText = Regex.Split(inputText, patterns);
        char firstElement = ' ';
        char lastElement = ' ';
        double firstAlphabet = 0;
        double secondAlphabet = 0;
        double result = 0;
        foreach (var word in splitText)
        {
            string pattern = @"\d+";
            Match numbers = Regex.Match(word, pattern);
            double number = int.Parse(numbers.Value);
            firstElement = word[0];
            lastElement = word[word.Length - 1];
            firstAlphabet = UpperOrLowerCase(firstElement);
            secondAlphabet = UpperOrLowerCase(lastElement);
            result += SumAlphabet(firstAlphabet, secondAlphabet,firstElement,lastElement,number);

        }
        Console.WriteLine("{0:0.00}",result);
    }

    static double SumAlphabet(double firstAlphabet, double secondAlphabet,char firstElement,char lastElement,double number)
    {
       // double result = 0;
        string elementOne = firstElement.ToString();
        string elementTwo = lastElement.ToString();
        if (elementOne.Equals(elementOne.ToUpper()))
        {
            number /= firstAlphabet;
        }
        else
        {
            number *= firstAlphabet;
        }
        if (elementTwo.Equals(elementTwo.ToUpper()))
        {
            number -= secondAlphabet;
        }
        else
        {
            number += secondAlphabet;
        }
        return number;
    }

    static double UpperOrLowerCase(char Element)
    {
        double numsAlphabet = 0;
        string element1 = Element.ToString();
        

        if (element1.Equals(element1.ToUpper()))
        {
            numsAlphabet = Element - 64;
        }
        else
        {
            numsAlphabet = Element - 96;
        }
        
        return numsAlphabet;
    }
}
