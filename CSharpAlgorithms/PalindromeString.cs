using System;

namespace CSharpAlgorithms
{
    public class PalindromeString
    {
        public static bool IsPalindrome(string s)
        {
            int len = s.Length;
            int start = 0;
            int end = len - 1;

            while (start < end)
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
