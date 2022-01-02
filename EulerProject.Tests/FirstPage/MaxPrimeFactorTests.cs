using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class MaxPrimeFactorTests
    {
        [Theory]
        [InlineData(13195, 29)]
        [InlineData(600851475143, 6857)]
        public void PrimeFactor_ShouldReturnMaxFactor(long n, long expected)
        {
            IProblem solver = new MaxPrimeFactor();
            var result = solver.Solve(n);

            Assert.Equal(expected, result);
        }
    }
}
