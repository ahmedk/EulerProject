using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class SumSquareDifferenceTests
    {
        [Theory]
        [InlineData(10, 2640)]
        [InlineData(100, 25164150)]
        public void SumSquareDifference(int max, int multiple)
        {
            IProblem solver = new SumSquareDifference();
            var result = solver.Solve(max);
            Assert.Equal(multiple, result);
        }
    }
}
