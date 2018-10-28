using System;
using Xunit;
using MaxStack.Classes;

namespace GetMaxTest
{
    public class GetMaxTest
    {
        /// <summary>
        /// Tests max stack and passes in a number to automatically add nodes
        /// </summary>
        /// <param name="itemNumber">Both the number of items that are needed to add as well as what max should be.</param>
        [Theory]
        [InlineData(99)]
        [InlineData(1502)]
        [InlineData(358)]
        public void MaxInStackTest(int itemNumber)
        {
            Stack testStack = new Stack();

            // adds numbers 1 to item number
            for(int i = 1; i < itemNumber+1; i++)
            {
                testStack.Push(new Node(i));
            }

            // returns true if the max is the same as the last itemnumber added
            Assert.True(testStack.GetMax() == itemNumber);
        }
    }
}
