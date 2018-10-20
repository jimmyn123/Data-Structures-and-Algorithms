using System;
using Day06_LinkedList.Classes;
using static System.Console;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList input = new LList(new Node(5));
            input.Add(new Node(4));
            input.Add(new Node(3));
            input.Add(new Node(2));
            input.Add(new Node(1));

            input.Print();
            Reverse(input);
        }

        public static LList Reverse(LList input)
        {
            Node prev = null;
            Node curr = input.Head;

            while(curr != null)
            {
                Node nextCurr = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = nextCurr;
            }

            return input;
        }
    }
}
