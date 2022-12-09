using System;
using System.Linq;

//Write a program that finds the summation of every number 
//from 1 to num. The number will always be a positive integer 
//greater than 0.

public static class SumIntegerUpToN
{
    public static int summation(int num)
    {
        return Enumerable.Range(1, num).Sum();
    }
}

