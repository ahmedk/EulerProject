using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class NthPrimeTests
    {
        [Theory]
        [InlineData(6, 13)]
        [InlineData(10001, 104743)]
        public void NthPrime(int term, int expected)
        {
            var solver = new NthPrime();
            var result = solver.Solve(term);
            Assert.Equal(expected, result);
        }
    }
}
