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

        
        


        int n = newNum.Sum();
        Console.Write(n);

        //Method 2
        //num.Select(s => newNum.Add(int.Parse(s.ToString()))).Sum();


        

    }

    //Method 3
    //public static int SumOfNumbers(int num)
    //{
    //    int sum = 0;
    //    while (sum > 0)
    //    {
    //        sum += num % 10;
    //        num /= 10;
    //    }
    //    return sum;
    //}
}