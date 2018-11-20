using System;
using Xunit;
using static Insertion_Sort.Program;

namespace Insertion_Sort_Test
{
    public class Insertion_Sort
    {
        /// <summary>
        /// Tests insertion sort
        /// </summary>
        /// <param name="input">the input array</param>
        /// <param name="idx">the index of the return value</param>
        /// <param name="expected">the expected return</param>
        [Theory]
        [InlineData(new int[]{9,5,3}, 1, 5)]
        [InlineData(new int[]{7,5,3,9,11}, 2, 7)]
        [InlineData(new int[]{13,5,9,4}, 0, 4)]
        public void SortTest(int[] input, int idx, int expected)
        {
            int[] sorted = InsertionSort(input);
            Assert.True(sorted[idx] == expected);
        }
    }
}
