using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class SpecialPythagoreanTripletTests
    {
        [Theory]
        [InlineData(1000, 31875000)]
        public void LargestProduct_Should_Calculate(int sum, long expected)
        {
            var solver = new SpecialPythagoreanTriplet();
            var result = solver.Solve(sum);
            Assert.Equal(expected, result);
        }
    }
}
