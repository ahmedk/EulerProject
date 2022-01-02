using EulerProject.FirstPage;
using Xunit;

namespace EulerProject.Tests.FirstPage
{
    public class LargestPalindromProductTests
    {
        [Theory]
        [InlineData(2, 9009)]
        [InlineData(3, 906609)]
        public void LargestPalindromProduct_Should_Return_Expected(int size, int expected)
        {
            IProblem solver = new LargestPalindromeProduct();
            var result = solver.Solve(size);

            Assert.Equal(expected, result);
        }
    }
}
