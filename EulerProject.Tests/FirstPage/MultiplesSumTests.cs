using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class MultiplesSumTests
    {
        [Theory]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        public void MultiplesOf3And5(int max, int sum)
        {
            IProblem solver = new MultiplesSum();
            var result = solver.Solve(max);
            Assert.Equal(sum, result);
        }
    }
}
