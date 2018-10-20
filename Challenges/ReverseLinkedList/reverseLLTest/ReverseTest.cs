using System;
using Xunit;
using static ReverseLinkedList.Program;
using Day06_LinkedList.Classes;

namespace ReverseLLTest
{
    public class ReverseTest
    {
        // creates linked list with values 1 -> 2 -> 3 -> 4 ->5
        LList input = new LList(new Node(5));
        LList input2 = new LList(new Node(1));

        public ReverseTest()
        {
            // adds to the first LL
            input.Add(new Node(4));
            input.Add(new Node(3));
            input.Add(new Node(2));
            input.Add(new Node(1));

            // adds to thesecond LL
            input2.Add(new Node(3));
            input2.Add(new Node(5));
            input2.Add(new Node(7));
            input2.Add(new Node(9));
        }

        /// <summary>
        /// Tests if the it can reverse the first array with different numbers, checks each position to make sure they are opposite the starting
        /// </summary>
        /// <param name="position">the position to look at</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData(0, 5)]
        [InlineData(1, 4)]
        [InlineData(2, 3)]
        [InlineData(3, 2)]
        [InlineData(4, 1)]
        public void LLOneWillReverseTest(int position, int expected)
        {
            LList reversed = Reverse(input);
            Node curr = reversed.Head;

            for(int i = 0; i < position; i++)
            {
                curr = curr.Next;
            }
            Assert.True((int)curr.Value == expected);
        }

        /// <summary>
        /// Tests if the it can reverse a second array with different numbers, checks each position to make sure they are opposite the starting
        /// </summary>
        /// <param name="position">the position to look at</param>
        /// <param name="expected">expected value</param>
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 3)]
        [InlineData(2, 5)]
        [InlineData(3, 7)]
        [InlineData(4, 9)]
        public void LLTwoWillReverseTest(int position, int expected)
        {
            LList reversed = Reverse(input2);
            Node curr = reversed.Head;

            for(int i = 0; i < position; i++)
            {
                curr = curr.Next;
            }
            Assert.True((int)curr.Value == expected);
        }
    }
}
