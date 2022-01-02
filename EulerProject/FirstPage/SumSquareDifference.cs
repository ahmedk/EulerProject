namespace EulerProject.FirstPage
{
    /// <summary>
    /// #6
    /// Name: Sum square difference
    /// Problem: Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum
    /// </summary>
    public class SumSquareDifference : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var max = (int)args[0];
                    return CalculateDifference(max);
                    //return OptimizedCalculateDifference(max);
                }
            }
            return 0;
        }

        private int CalculateDifference(int max)
        {
            var sum = max * (max + 1) / 2;
            var sumSquared = (int)Math.Pow(sum, 2);
            var squareSum = 1;
            for (var i = 2; i <= max; i++)
            {
                squareSum += (int)Math.Pow(i, 2);
            }
            return sumSquared - squareSum;
        }

        private int OptimizedCalculateDifference(int max)
        {
            var sum = max * (max + 1) / 2;
            var sumSquared = (int)Math.Pow(sum, 2);
            var squareSum = max * (max + 1) * (2 * max + 1) / 6;
            return sumSquared - squareSum;
        }
    }
}
