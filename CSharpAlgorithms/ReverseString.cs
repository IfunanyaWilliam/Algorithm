using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class ReverseString
    {
        public static string Solution(string s)
        {
            string newString = "";
            for (var i = s.Length - 1; i >= 0; i--)
            {
                newString += s[i];
            }
            return newString;
        }

        //public static string Solution1(string str) => string.Join("", str.Reverse());
    }
}
