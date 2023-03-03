using Xunit;
using BracketChecker;

namespace BracketChecker.Tests
{
    public class BracketCheckerTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("()", true)]
        [InlineData("[]", true)]
        [InlineData("{}", true)]
        [InlineData("<>", true)]
        [InlineData("(())", true)]
        [InlineData("([])", true)]
        [InlineData("({})", true)]
        [InlineData("<[]>", true)]
        [InlineData("(])", false)]
        [InlineData("[)", false)]
        [InlineData("{]", false)]
        [InlineData("<)]>", false)]
        [InlineData("([)]", false)]
        [InlineData("(({})", false)]
        public void TestBracketChecker(string input, bool expected)
        {
            // Arange

            // Act
            bool result = BracketChecker.Solution(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
