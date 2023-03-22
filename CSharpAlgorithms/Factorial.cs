using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public static class Factorial
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
