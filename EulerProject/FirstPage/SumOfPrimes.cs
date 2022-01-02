namespace EulerProject.FirstPage
{
    /// <summary>
    /// #10
    /// Name: Summation of primes
    /// Problem: Find the sum of all the primes below two million
    /// </summary>
    public class SumOfPrimes : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(long))
                {
                    var max = (long)args[0];
                    return CalculateSum(max);
                    //return OptimizedCalculateSum(max); // couldn't implement
                }
            }
            return 0;
        }

        private long CalculateSum(long max)
        {
            if (max <= 1)
                return 0;
            if (max == 2)
                return 2;
            long sum = 2;
            var currentPrime = 3;
            while (max >= currentPrime)
            {
                sum += currentPrime;
                do
                {
                    currentPrime += 2;
                }
                while (!IsPrime(currentPrime));
                if (currentPrime > max)
                    break;
            }
            return sum;
        }

        private bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            else if (number < 4)
                return true;
            else if (number % 2 == 0)
                return false;
            else if (number < 9)
                return true;
            else if (number % 3 == 0)
                return false;
            else
            {
                var r = Math.Floor(Math.Sqrt(number));
                var factor = 5;
                while (r >= factor)
                {
                    if (number % factor == 0)
                        return false;
                    if (number % (factor + 2) == 0)
                        return false;
                    factor += 6;
                }
            }
            return true;
        }

        private long OptimizedCalculateSum(long max)
        {
            var sieveBound = (max - 1) / 2;
            var sieve = new bool[sieveBound];
            var crossLimit = (Math.Floor(Math.Sqrt(max)) - 1) / 2;
            for(var i = 1; i <= crossLimit; i++)
            {
                if (!sieve[i - 1])
                {
                    for(var j = 2 * i * (i + 1); j < sieveBound; j += 2 * i + 1)
                    {
                        sieve[j] = true;
                    }
                }
            }
            long sum = 2;
            for (long i = 1; i <= sieveBound; i++)
                if (!sieve[i - 1]) sum += (2 * i + 1);

            return sum;
        }
    }
}
