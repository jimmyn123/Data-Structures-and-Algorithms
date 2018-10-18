using System;
using Xunit;
using Day06_LinkedList.Classes;
using static ll_merge.Program;

namespace ll_merge_test
{
    public class ll_merge_test
    {

        /// <summary>
        /// Iterates through the list and makes sure the values at the node number are the correct values after merge
        /// </summary>
        /// <param name="expected">the expected value at the position</param>
        /// <param name="position">the nth node</param>
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        public void TestMerge(int expected, int position)
        {
            // initializes two lists
            LList one = new LList(new Node(3));
            LList two = new LList(new Node(6));

            // add values to the lists
            one.Add(new Node(1));
            two.Add(new Node(5));
            two.Add(new Node(4));
            two.Add(new Node(2));

            // merges the two lists
            LList merged = merge(one, two);

            int iterator = 1;
            Node nthNode = merged.Head;

            // iterates to the nth node
            while(iterator < position)
            {
                nthNode = nthNode.Next;
                iterator++;
            }

            int check = (int)nthNode.Value;

            // compares the values
            Assert.True(check == expected);
        }
    }
}
