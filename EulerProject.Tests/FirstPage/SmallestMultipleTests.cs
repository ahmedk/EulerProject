using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class SmallestMultipleTests
    {
        [Theory]
        [InlineData(10, 2520)]
        [InlineData(20, 232792560)]
        public void SmallestMultiples(int max, int multiple)
        {
            IProblem solver = new SmallestMultiple();
            var result = solver.Solve(max);
            Assert.Equal(multiple, result);
        }
    }
}
