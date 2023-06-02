using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAlgorithms
{
    public static class IsogramChecker
    {
        //An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        //Implement a function that determines whether a string that contains only letters is an isogram.
        //Assume the empty string is an isogram. Ignore letter case.
        //Test Cases:
        //isIsogram "Dermatoglyphics" = true
        //isIsogram "moose" = false
        //isIsogram "aba" = false

        public static bool IsIsogram(string str)
        {
            if (String.IsNullOrEmpty(str))
                return true;

            Char[] nstr = str.ToLower().ToCharArray();
            Dictionary<char, int> words = new Dictionary<Char, int>();

            foreach (var c in nstr)
            {
                if (words.ContainsKey(c))
                    words[c]++;
                else
                    words[c] = 1;
            }

            foreach (KeyValuePair<char, int> pair in words)
            {
                if (pair.Value > 1)
                    return false;
            }

            return true;

            //Alternative Method
            //if (String.IsNullOrEmpty(str))
            //    return true;

            //return str.ToLower().Distinct().Count() == str.Length; 
        }
    }
}
