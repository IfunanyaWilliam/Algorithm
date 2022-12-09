using System;
using System.Collections.Generic;
using System.Linq;

public class SumofDigitsOfNum
{
    //A program to sum the digits of a number
    public static void Main()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        List<int> newNum = new List<int>();

        foreach (var s in num)
        {
            newNum.Add(int.Parse(s.ToString()));
        }

        //num.Select(s => newNum.Add(int.Parse(s.ToString()))).ToList();

        int n = newNum.Sum();
        Console.Write(n);

    }
}