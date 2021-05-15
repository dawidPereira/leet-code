using System;
using FluentAssertions;
using LeetCode.Easy;
using Xunit;

namespace LeetCode.Tests
{
    public class ReverseIntegerTests
    {
        private readonly ReverseInteger _systemUnderTests;

        public ReverseIntegerTests()
        {
            _systemUnderTests = new ReverseInteger();
        }

        [Theory]
        [InlineData(123, 321)]
        [InlineData(782, 287)]
        [InlineData(99992, 29999)]
        [InlineData(19922, 22991)]
        public void GivenPositiveNumber_WhenAllNumbersInRange_ShouldReversNumbers(int value, int expectedResult)
        {
            var result = ReverseInteger.Reverse(value);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(-123, -321)]
        [InlineData(-782, -287)]
        [InlineData(-99992, -29999)]
        [InlineData(-19922, -22991)]
        public void GivenNegativeNumber_WhenAllNumbersInRange_ShouldReversNumbers(int value, int expectedResult)
        {
            var result = ReverseInteger.Reverse(value);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(1105032705, 0)]
        [InlineData(-1105032705, 0)]
        [InlineData(-1105232705, 0)]
        [InlineData(1105037283, 0)]
        public void GivenAnyNumber_WhenNumberIsOutOfRangeRange_ShouldReturnZero(int value, int expectedResult)
        {
            var result = ReverseInteger.Reverse(value);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(1120, 211)]
        [InlineData(-3220, -223)]
        public void GivenAnyNumber_WhenLastDigitOfReversedNumberIsZero_ShouldReturnNumberWithoutThisDigit(int value, int expectedResult)
        {
            var result = ReverseInteger.Reverse(value);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(null)]
        public void GivenNullValue_ShouldThrowArgumentException(int? value)
        {
            Action action = () => ReverseInteger.Reverse(value);
            action.Should().Throw<ArgumentException>()
                .WithMessage("Value can not be null");
        }
    }
}
