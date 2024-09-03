using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpAlgorithms
{
    //Assume you have 2 inputs, the first one is an array and the second is the target:
    //which is the sum of 2 elements in the array. All you have to do is to find those
    //2 numbers and return their indices. 
    //Eg
    //input 1: { 2, 7, 11, 15 }, target: 9 - answer is [0,1] since 2+7 = 9
    //input 2: { 3, 2, 4 }, target: 6 - answer is [1, 2] since 2 + 4 = 6


    //SOLUTION
    //input 1: { 2, 7, 11, 15 }, target: 9 - answer is [0,1] since 2+7 = 9

    //If I start iterating through a loop, I get to the first element which is 2.
    //Next, Let's deduct these 2 from the target which is 9: will get 7.
    //let's add 2 to the dictionary with its index, Now dictionary will have [2, 0]
    //Going for the second iteration.Next value is 7.
    //Again did the deduction: 9-7: will get 2.
    //We will see if the dictionary has an entry of 2. Yes it has.Well these are the 2 indices that makes the sum,
    //so just return the value from the dictionary(index of 2) and the current value of i(index of 7). Because 2 + 7 = 9.

    public static class ArrayTwoSum
    {
        public static int[] TwoSumIndexes(int[] numAarry, int target)
        {
            int length = numAarry.Length;
            Dictionary<int, int> indexes = new Dictionary<int, int>();

            for(int i = 0;  i < length; i++)
            {
                int currentNumber = numAarry[i];
                int firstNumber = target - currentNumber;

                if (indexes.ContainsKey(firstNumber))
                {
                    return new int[] { Array.IndexOf(numAarry, firstNumber), i };
                }

                indexes[currentNumber] = i;
            }

            return Array.Empty<int>();
        }
    }
}
