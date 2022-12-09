using System;
using System.Collections.Generic;
using System.Linq;

public static class SumTwoSmallestIntegerArray
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        var nums = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            nums.Add(numbers[i]);
        }

        nums.Sort();
        return nums[0] + nums[1];
    }

    public static int sumTwoSmallestNumbers1(int[] numbers)
    {
        return numbers.OrderBy(i => i).Take(2).Sum();
    }
}

