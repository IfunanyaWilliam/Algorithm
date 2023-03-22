using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public static class IntegerToBinary
    {
        public static string ConvertToBinary()
        {
            int n, i;
            string newString = "";
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number = ");
            for (i = i - 1; i >= 0; i--)
            {
                newString += (a[i]).ToString();
            }

            return newString;
        }
    }
}
