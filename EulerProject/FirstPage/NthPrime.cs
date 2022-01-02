namespace EulerProject.FirstPage
{
    /// <summary>
    /// #7
    /// Name: 10001st prime
    /// Problem: What is the 10 001st prime number?
    /// </summary>
    public class NthPrime : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var term = (int)args[0];
                    return GetPrimeNumber(term);
                    //return OptimizedGetPrimeNumber(term);
                }
            }
            return 0;
        }

        private object GetPrimeNumber(int term)
        {
            if (term == 1)
                return 2;
            else if (term == 2)
                return 3;
            var primes = new List<long> { 2, 3 };
            var currentPrime = 3;
            var i = 3;
            while (i <= term)
            {
                while (primes.Any(p => currentPrime % p == 0))
                    currentPrime += 2;
                primes.Add(currentPrime);
                i++;
            }

            return currentPrime;
        }

        private object OptimizedGetPrimeNumber(int term)
        {
            var count = 1;
            var candidate = 1;
            do
            {
                candidate += 2;
                if (IsPrime(candidate)) count++;
            } while (count < term);
            return candidate;
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
    }
}
