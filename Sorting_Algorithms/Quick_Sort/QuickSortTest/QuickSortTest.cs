using System;
using Xunit;
using static Quick_Sort.Program;

namespace QuickSortTest
{
    public class QuickSortTest
    {
        /// <summary>
        /// Tests the sort with the expected value at the index given
        /// </summary>
        /// <param name="myArray">the array to sort</param>
        /// <param name="idx">the index of the value</param>
        /// <param name="expected">the expected value</param>
        [Theory]
        [InlineData(new int[]{9,5,3}, 0, 3)]
        [InlineData(new int[]{ 9,5,3}, 1, 5)]
        [InlineData(new int[]{ 9,5,3}, 2, 9)]
        public void SortTest(int[] myArray, int idx, int expected)
        {
            QuickSort(myArray, 0, myArray.Length - 1);

            Assert.True(myArray[idx] == expected);
        }
    }
}
