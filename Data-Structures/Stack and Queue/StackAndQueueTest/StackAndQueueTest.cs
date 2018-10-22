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
            Assert.True((int)st.Peek().Value == 50);
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
    }
}
