using System;
using System.Linq;

namespace CSharpAlgorithms
{
    public static class ReverseWordsWithSpaces
    {
        public static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }

            return string.Join(" ", words);

            //From the badass
            //return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
        }
    }
}
