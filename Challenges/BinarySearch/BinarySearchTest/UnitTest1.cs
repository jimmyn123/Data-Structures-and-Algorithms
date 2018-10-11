using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests the binary search function of our program, it should return the right indices
        /// </summary>
        /// <param name="input">the array input</param>
        /// <param name="value">the search value</param>
        /// <param name="expected">the expected index to return</param>
        [Theory]
        [InlineData(new [] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        // tests edge case
        [InlineData(new [] { 1,2,3}, 3, 2)]
        // test for value that is not in array
        [InlineData(new [] {2, 4}, 1, -1)]
        public void BinarySearchTest(int[] input, int value, int expected)
        {
            Assert.True(BinarySearchInt(input, value) == expected);
        }
    }
}
