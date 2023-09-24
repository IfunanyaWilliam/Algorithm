using System;
using System.Collections.Generic;
using System.Linq;

public class ArmStrongNumber
{
    //Armstrong number is a number that is equal to the sum of cubes of its digits.
    //For example 0, 1, 153, 370, 371 and 407 are the Armstrong numbers.
    public static void Main()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        int cube;
        List<int> newNum = new List<int>();
        for (int i = num.Length - 1; i >= 0; i--)
        {
            cube = int.Parse(num[i].ToString());
            cube = cube * cube * cube;
            newNum.Add(cube);
        }

        if (newNum.Sum() == int.Parse(num))
        {
            Console.WriteLine("{0} is an ArmStrong Number", num);
        }
        else
        {
            Console.WriteLine("{0} is not an ArmStrong Number", num);
        }

        //Alternatively
        //string num = Console.ReadLine();

        //double result = num.ToArray()
        //                    .Select(s =>
        //                        Math.Pow(double.Parse(s.ToString()), 3))
        //                    .Sum();
        //if (result == double.Parse(num))
        //{ Console.Write("Yes"); }
        //else { Console.Write("Not an Armstrong number"); }

    }
}