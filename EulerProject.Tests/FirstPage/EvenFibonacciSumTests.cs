using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class EvenFibonacciSumTests
    {
        [Fact]
        public void EvenFibonacciSum_ShouldCalculateSum()
        {
            IProblem fibonacci = new EvenFibonacciSum();
            var result = fibonacci.Solve(4000000);

            Assert.Equal(4613732, result);
        }
    }
}
