using System;
using Xunit;
using Stack_and_Queue.Classes;

namespace StackAndQueueTest
{
    public class StackAndQueueTest
    {
        // Tests the push for a stack
        [Fact]
        public void PushNodeOnStackTest()
        {
            Stack st = new Stack(new Node(7));
            st.Push(new Node(50));
            Assert.True((int)st.Top.Value == 50);
        }
        // Tests the Pop for a stack
        [Fact]
        public void PopNodeOnStackTest()
        {
            Stack st = new Stack(new Node(7));
            st.Push(new Node(50));
            st.Pop();
            Assert.True((int)st.Peek().Value == 7);
        }

        // Tests the Peek for a stack
        [Fact]
        public void PeekNodeOnStackTest()
        {
            Stack st = new Stack(new Node(7));
            st.Push(new Node(50));
            Assert.True((int)st.Peek().Value == 50);
        }

        // Tests the Enqueue for a Queue
        [Fact]
        public void EnqueueNodeOnQueueTest()
        {
            Queue q = new Queue(new Node(7));
            q.Enqueue(new Node(50));
            Assert.True((int)q.Rear.Value == 50);
        }

        // Tests the Dequeue for a Queue
        [Fact]
        public void DequeueNodeOnQueueTest()
        {
            Queue q = new Queue(new Node(7));
            q.Enqueue(new Node(50));
            q.Dequeue();
            Assert.True((int)q.Front.Value == 50);
        }

        // Tests the Peek for a Queue
        [Fact]
        public void PeekNodeOnQueueTest()
        {
            Queue q = new Queue(new Node(7));
            q.Enqueue(new Node(50));
            Assert.True((int)q.Peek().Value == 7);
        }
    }
}
