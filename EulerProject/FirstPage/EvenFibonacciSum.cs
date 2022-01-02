namespace EulerProject.FirstPage
{
    /// <summary>
    /// #2
    /// Name: Even Fibonacci numbers
    /// Problem: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms
    /// </summary>
    public class EvenFibonacciSum : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var max = (int)args[0];
                    return SumEvenTermsWithMax(max);
                    //return OptimizedEvenTermsSum(max);
                }
            }
            return 0;
        }

        private int SumEvenTermsWithMax(int max)
        {
            var term1 = 1;
            var term2 = 2;
            var sum = 2;
            while (term2 < max)
            {
                var term = term1 + term2;
                if (term % 2 == 0)
                    sum += term;
                term1 = term2;
                term2 = term;
            }

            return sum;
        }

        private int OptimizedEvenTermsSum(int max)
        {
            var term1 = 1;
            var term2 = 1;
            var term3 = term1 + term2;
            var sum = 0;
            while (term3 < max)
            {
                sum += term3;
                term1 = term3 + term2;
                term2 = term3 + term1;
                term3 = term1 + term2;
            }

            return sum;
        }
    }
}
