
using System;

namespace CSharpAlgorithms
{
    public static class Sort_Selection
    {
        //Psudo code for selection sort
        //it has n(n-2)/2 worst case runtime

       // FUNCTION SelectionSort(array A, n)
          // A is the array to be sorted
          // n is the number of elements in the array

        //  FOR i FROM 0 TO n-2
        //    Find the minimum element in the unsorted part of the array
        //    minIndex = i

        //    FOR j FROM i+1 TO n-1
        //      IF A[j] < A[minIndex] THEN
        //        minIndex = j
        //      END IF
        //    END FOR

        //    // Swap the found minimum element with the first element of the unsorted part
        //    IF minIndex != i THEN
        //      temp = A[i]
        //      A[i] = A[minIndex]
        //      A[minIndex] = temp
        //    END IF
        //  END FOR

        //  RETURN A
        //END FUNCTION

        public static int[] Sort(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

            return array;
        }
    }
}
