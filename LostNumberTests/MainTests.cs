using FluentAssertions;
using LostNumber;
using Xunit;

namespace LostNumberTests
{
    public class MainTests
    {
        private readonly Main _searcher;
        public MainTests()
        {
            _searcher = new Main();
        }

        [Theory]
        [InlineData(null, 0)]
        [InlineData(new[] { 3 }, 0)]
        [InlineData(new[] { 3, 4 }, 0)]
        [InlineData(new[] { 3, 5 }, 4)]
        [InlineData(new[] { 4, 5, 7 }, 6)]
        [InlineData(new[] { 9, 10, 12, 13 }, 11)]
        [InlineData(new[] { 13, 11, 9, 10 }, 12)]
        public void TestSearchNumber(int [] numbers, int expected)
        {
            int actual = _searcher.SearchNumber(numbers);
            actual.Should().Be(expected);
        }
    }
}
