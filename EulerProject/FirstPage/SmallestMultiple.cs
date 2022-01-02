namespace EulerProject.FirstPage
{
    /// <summary>
    /// #5
    /// Name: Smallest multiple
    /// Problem: What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class SmallestMultiple : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var max = (int)args[0];
                    //return CalculateMultiple(max); // calculated manually to solve problem 
                    return OptimizedCalculateMultiple(max);
                }
            }
            return 0;
        }

        private object OptimizedCalculateMultiple(int max)
        {
            if (max <= 1)
                return 1;

            var primes = new List<int>();
            var currentPrime = 2;
            var limit = Math.Sqrt(max);
            var result = 1;
            while (max > currentPrime)
            {
                while (primes.Any(p => currentPrime % p == 0))
                    currentPrime += currentPrime == 2 ? 1 : 2;
                if (currentPrime > max)
                    break;
                primes.Add(currentPrime);
                var pow = currentPrime <= limit ? Math.Floor(Math.Log10(max) / Math.Log10(currentPrime)) : 1;
                result *= (int)Math.Pow(currentPrime, pow);
            }
            return result;
        }

        private int CalculateMultiple(int max)
        {
            if (max <= 1)
                return 1;
            var primes = new List<int> { 2 };
            var currentPrime = 3;
            while (max > currentPrime)
            {
                while (primes.Any(p => currentPrime % p == 0))
                    currentPrime += 2;
                if (currentPrime > max)
                    break;
                primes.Add(currentPrime);
            }
            var result = 1;
            foreach (var prime in primes) result *= prime;
            for (var i = max; i > 1; i--)
            {
                if (result % i == 0)
                    continue;
                var temp = result % i;
                //result *= i;
            }
            return result;
        }
    }
}
