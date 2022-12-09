using System;
using System.Collections.Generic;
using System.Linq;

public class ArmStrongNumber
{
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

    }
}