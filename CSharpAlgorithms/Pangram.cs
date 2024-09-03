
namespace CSharpAlgorithms
{
    public static class Pangram
    {
        public static bool IsPangram(string str)
        {
            if (str.Length == 0)
                return false;
            int start = 0;
            var myLetters = new HashSet<char>();
            var letters = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

            while (start < str.Length)
            {
                var check1 = char.ToLower(str[start]);
                if (letters.Contains(check1))
                {
                    myLetters.Add(check1);
                }

                start++;
            }

            return myLetters.Count == 26;
        }

        //Best Solutions
        //return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        //return new HashSet<char>(str.ToLower().Where(char.IsLetter)).Count == 26;
    }
}
