using System;
using System.Collections.Generic;

namespace CSharpAlgorithms
{
    //Assume you have 2 inputs, the first one is an array and the second is the target:
    //which is the sum of 2 elements in the array. All you have to do is to find those
    //2 numbers and return their indices. 
    //Eg
    //input 1: { 2, 7, 11, 15 }, target: 9 - answer is [0,1] since 2+7 = 9
    //input 2: { 3, 2, 4 }, target: 6 - answer is [1, 2] since 2 + 4 = 6


    public static class ArrayTwoSum
    {
        public static int[] TwoSumIndexes(int[] numAarry, int target)
        {
            int length = numAarry.Length;
            Dictionary<int, int> indexes = new Dictionary<int, int>();

            for(int i = 0;  i < length; i++)
            {
                int currentNumber = numAarry[i];
                int secondNumber = target - currentNumber;

                if (indexes.ContainsKey(secondNumber))
                {
                    return new int[] { Array.IndexOf(numAarry, secondNumber), i };
                }

                indexes[currentNumber] = i;
            }

            return Array.Empty<int>();
        }
    }
}
