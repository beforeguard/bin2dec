using BinaryToDecimal.Services;
using FluentAssertions;
using Xunit;

namespace BinaryToDecimal.Tests.Services
{
    public class BinaryToDecimalServiceTests
    {
        private readonly BinaryToDecimalService _service = new();

        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("10", "2")]
        [InlineData("11", "3")]
        [InlineData("100", "4")]
        [InlineData("101", "5")]
        [InlineData("110", "6")]
        [InlineData("111", "7")]
        [InlineData("1000", "8")]
        public void ConvertToDecimal_Should_ConvertBinaryValueToEquivalentDecimalValue(string input, string expected)
        {
            _service.ConvertToDecimal(input).Should().Be(expected);
        }
    }
}
