using System;
using Xunit;
using Stack_and_Queue.Classes;

namespace StackAndQueueTest
{
    public class StackAndQueueTest
    {
        [Fact]
        public void PushNodeOnStackTest()
        {
            Stack st = new Stack(new Node(7));
            st.Push(new Node(50));
            Assert.True((int)st.Peek().Value == 50);
        }
    }
}
