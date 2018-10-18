using System;
using Xunit;
using Day06_LinkedList.Classes;

namespace ll_merge_test
{
    public class ll_merge_test
    {
        // initializes two lists
        LList one = new LList(new Node(3));
        LList two = new LList(new Node(6));

        private ll_merge_test()
        {
            // add values to the lists
            one.Add(new Node(1));
            two.Add(new Node(5));
            two.Add(new Node(4));
            two.Add(new Node(2));
        }

        [Theory[InlineData]
        ()
        public void TestMerge(int expected, int position)
        {

        }
    }
}
