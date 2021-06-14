using System;
using System.Linq;

namespace Algoritmos
{
    public class BasicAlgorithms
    {
        public double CalculateSum(double x, double y)
            => x + y;

        public double CalculateSubtraction(double x, double y)
            => x - y;

        public double CalculateMultiplication(double x, double y)
            => x * y;

        public double CalculateDivision(double x, double y)
            => x / y;

        public double CalculateExponential(double b, double e)
            => b < 0 && e < 0 && e % 2 == 0 ? Math.Pow(b, e) * -1 : Math.Pow(b, e);

        public double CalculateFactorial(double n)
        {
            if (n < 0)
            {
                return -1;
            }
            else
            {
                if (n == 0)
                    return 1;
                else
                    return n * CalculateFactorial(n - 1);
            }
        }

        public bool IsPalindrome(string word)
            => word.ToLower().Equals(new string(word.ToLower().Reverse().ToArray()));
    }
}
