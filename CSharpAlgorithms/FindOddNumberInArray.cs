using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class FindOddNumberInArray
    {
        public static int FindOddNumber(int[] seq)
        {
            if (seq.Length == 1)
            {
                return seq[0];
            }

            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (var num in seq)
            {
                if (count.ContainsKey(num))
                    count[num]++;
                else
                    count[num] = 1;
                //line 25 could also be
                // count.Add(num, 1);
            }

            foreach (KeyValuePair<int, int> pair in count)
            {
                if (pair.Value % 2 != 0)
                    return pair.Key;
            }

            return 0;
        }
    }
}
