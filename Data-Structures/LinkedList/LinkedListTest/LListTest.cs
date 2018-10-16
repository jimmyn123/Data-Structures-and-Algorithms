using System;
using Xunit;
using Day06_LinkedList.Classes;

namespace LinkedListTest
{
    public class LListTest
    {
        /// <summary>
        /// Tests the add at head
        /// </summary>
        /// <param name="value">value to be added</param>
        [Theory]
        [InlineData(9)]
        [InlineData(76)]
        [InlineData(11)]
        public void AddTest(int value)
        {
            LList list = new LList(new Node(7));
            list.Add(new Node(value));
            Assert.True((int)list.Head.Value == value);
        }

        /// <summary>
        /// Tests the print, returns true if the values have all printed out
        /// </summary>
        /// <param name="value">the node to be added</param>
        [Theory]
        [InlineData(9)]
        [InlineData(76)]
        [InlineData(11)]
        public void PrintTest(int value)
        {
            LList list = new LList(new Node(7));
            list.Add(new Node(value));
            Assert.True(list.Print() == true);
        }

        /// <summary>
        /// Tests the add before, it should add at the end
        /// </summary>
        /// <param name="value">The value of the added node</param>
        [Theory]
        [InlineData(9)]
        [InlineData(76)]
        [InlineData(11)]
        public void AppendTest(int value)
        {
            LList list = new LList(new Node(7));
            list.Add(new Node(19));
            list.Append(new Node(value));
            Assert.True((int)list.Head.Next.Next.Value == value);
        }

        /// <summary>
        /// Tests the add before, it should add before the 7
        /// </summary>
        /// <param name="value">The value of the added node</param>
        [Theory]
        [InlineData(9)]
        [InlineData(76)]
        [InlineData(11)]
        public void AddBeforeTest(int value)
        {
            Node firstNode = new Node(7);
            LList list = new LList(firstNode);
            list.AddBefore(new Node(value), firstNode);
            Assert.True((int)list.Head.Value == value);
        }

        /// <summary>
        /// Tests the add after, starts with 2 nodes initially and adds new node after the first created node
        /// </summary>
        /// <param name="value">the value of the new node</param>
        [Theory]
        [InlineData(9)]
        [InlineData(76)]
        [InlineData(11)]
        public void AddAfterTest(int value)
        {
            Node firstNode = new Node(7);
            LList list = new LList(firstNode);
            list.Add(new Node(18));
            list.AddAfter(new Node(value), firstNode);
            Assert.True((int)list.Head.Next.Next.Value == value);
        }



    }
}
