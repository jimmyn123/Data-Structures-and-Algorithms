using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new [] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        public void BinarySearchTest(int[] input, int value, int expected)
        {
            Assert.True(BinarySearch() == expected);
        }
    }
}
