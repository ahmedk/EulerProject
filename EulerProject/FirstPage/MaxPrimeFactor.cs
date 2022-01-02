namespace EulerProject.FirstPage
{
    /// <summary>
    /// #3
    /// Name: Largest prime factor
    /// Problem: What is the largest prime factor of the number
    /// </summary>
    public class MaxPrimeFactor : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(long))
                {
                    var number = (long)args[0];
                    var primes = CalculatePrimes(number);
                    return primes.Max();
                }
            }
            return 0;
        }

        private List<long> CalculatePrimes(long number)
        {
            var primes = new List<long> { 2 };
            var factors = new List<long>();
            var maxFactor = Math.Sqrt(number);
            var currentPrime = 2;
            if (number % currentPrime != 0)
                currentPrime++;
            while (number > 1 && currentPrime <= maxFactor)
            {
                while (number % currentPrime == 0)
                {
                    factors.Add(currentPrime);
                    number /= currentPrime;
                }

                currentPrime += 2;
                while (primes.Any(p => currentPrime % p == 0))
                    currentPrime += 2;
                primes.Add(currentPrime);
            }

            return factors;
        }
    }
}
