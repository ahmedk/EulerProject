using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class SumOfPrimesTests
    {
        [Theory]
        [InlineData(10, 17)]
        [InlineData(2000000, 142913828922)]
        public void SumOfPrimes_Should_Return_Sum(long max, long expected)
        {
            var solver = new SumOfPrimes();
            var result = solver.Solve(max);
            Assert.Equal(expected, result);
        }
    }
}
