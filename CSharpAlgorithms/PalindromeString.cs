using System;

namespace CSharpAlgorithms
{
    public class PalindromeString
    {
        public static bool IsPalindrome(string s)
        {
            int middleChar = s.Length/2;
            int start = 0;
            int end = s.Length - 1;

            while (start < middleChar)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
