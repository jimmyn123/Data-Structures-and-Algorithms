using System;
using Xunit;
using QueueWithStack.Classes;

namespace QueueWithStackTest
{
    public class QueueWithStackTest
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(9, 9)]
        [InlineData(7, 7)]
        public void TestEnqueue(int numNodes, int expected)
        {
            // creates a new q and enqueues numNodes
            Queue q = new Queue();
            for(int i = 0; i < numNodes; i++)
            {
                q.Enqueue(new Node(i));
            }

            // size should be able to number of nodes
            Assert.True(q.Rear.Size == expected);
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(9, 8)]
        [InlineData(7, 6)]
        public void TestDequeue(int numNodes, int expected)
        {
            // creates a new q and enqueues numNodes
            Queue q = new Queue();
            for (int i = 0; i < numNodes; i++)
            {
                q.Enqueue(new Node(i));
            }

            // take one out
            q.Dequeue();

            // size should be number of nodes - 1
            Assert.True(q.Rear.Size == expected);
        }
    }
}
