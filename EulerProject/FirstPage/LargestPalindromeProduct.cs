using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.FirstPage
{
    /// <summary>
    /// #4
    /// Name: Largest palindrome product
    /// Problem: Find the largest palindrome made from the product of two 3-digit numbers
    /// </summary>
    public class LargestPalindromeProduct : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var size = (int)args[0];
                    var max = (int)Math.Pow(10, size) - 1;
                    var min = (int)Math.Pow(10, size - 1);
                    return MaxPalindrome(min, max);
                    //return OptimizedMaxPalindrome(min, max);
                }
            }
            return 0;
        }

        private int MaxPalindrome(int min, int max)
        {
            var maxProd = 1;
            var n1 = max;
            while (n1 >= min)
            {
                var n2 = n1 - 1;
                while (n2 >= min)
                {
                    var product = n1 * n2;
                    if(IsPalindrom(product))
                        maxProd = product > maxProd ? product : maxProd;
                    n2--;
                }
                n1--;
            }
            return maxProd;
        }

        private bool IsPalindrom(int number)
        {
            var str = number.ToString();
            var reversed = new string(str.Reverse().ToArray());
            return str == reversed;
        }

        private int OptimizedMaxPalindrome(int min, int max)
        {
            var maxProd = 1;
            var n1 = max;
            while (n1 >= min)
            {
                var n2 = max;
                while (n2 >= n1)
                {
                    var product = n1 * n2;
                    if (product <= maxProd)
                        break;

                    if(OptimizedIsPalindrom(product))
                        maxProd = product > maxProd ? product : maxProd;
                    n2--;
                }
                n1--;
            }
            return maxProd;
        }

        private bool OptimizedIsPalindrom(int number)
        {
            var reversed = 0;
            var n1 = number;
            while(n1 > 0)
            {
                reversed = 10 * reversed + n1 % 10;
                n1 /= 10;
            }
            return number == reversed;
        }
    }
}
