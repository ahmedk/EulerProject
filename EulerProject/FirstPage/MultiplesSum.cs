namespace EulerProject.FirstPage
{
    /// <summary>
    /// #1
    /// Name: Multiples of 3 or 5
    /// Problem: Find the sum of all the multiples of 3 or 5 below 1000
    /// </summary>
    public class MultiplesSum : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var max = (int)args[0];
                    var sum = 3;
                    for(var i = 4; i < max; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                            sum += i;
                    }
                    return sum;
                    //return OptimizedSumDivisible(max);
                }
            }
            return 0;
        }

        private static int OptimizedSumDivisible(int max)
        {
            return SumDivisableBy(3, max) + SumDivisableBy(5, max) - SumDivisableBy(15, max);
        }

        private static int SumDivisableBy(int n, int max)
        {
            var ceiling = (max - 1) / n;
            return n * ceiling * (ceiling + 1) / 2;
        }
    }
}
