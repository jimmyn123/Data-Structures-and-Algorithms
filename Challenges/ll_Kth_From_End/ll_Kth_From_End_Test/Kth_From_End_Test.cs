using System;
using Xunit;
using Day06_LinkedList.Classes;
using static ll_Kth_From_End.Program;

namespace ll_Kth_From_End_Test
{
    public class Kth_From_End_Test
    {
        LList list;
        public Kth_From_End_Test()
        {
            LList list = new LList(new Node(1));
            list.Add(new Node(2));
            list.Add(new Node(3));
            list.Add(new Node(4));
            list.Add(new Node(5));
            list.Add(new Node(6));
            list.Add(new Node(7));
            list.Add(new Node(8));
            list.Add(new Node(9));
            list.Add(new Node(10));
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
