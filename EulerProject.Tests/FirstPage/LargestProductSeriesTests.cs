using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class LargestProductSeriesTests
    {
        [Theory]
        [InlineData(4, 5832)]
        [InlineData(13, 23514624000)]
        public void LargestProduct_Should_Calculate(int length, long expected)
        {
            var solver = new LargestProductSeries();
            var result = solver.Solve(length);
            Assert.Equal(expected, result);
        }
    }
}
