using System;
using Day06_LinkedList.Classes;
using static System.Console;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            LList one = new LList(new Node(3));
            one.Add(new Node(1));
            LList two = new LList(new Node(6));
            two.Add(new Node(5));
            two.Add(new Node(4));
            two.Add(new Node(2));

            WriteLine("List one has the following values: ");
            DisplayList(one);

            WriteLine("List two has the following values: ");
            DisplayList(two);
            
            LList merged = merge(one, two);
            WriteLine("After merging, list should be 1, 2, 3, 4, 5, 6");

            WriteLine("Actual");
            DisplayList(merged);
        }

        public static LList merge(LList one, LList two)
        {
            Node first = one.Head;
            Node second = two.Head;
            while(first.Next != null && second.Next != null)
            {
                Node nextFirst = first.Next;
                Node nextSecond = second.Next;
                first.Next = second;
                second.Next = nextFirst;
                first = nextFirst;
                second = nextSecond;
            }

            if(first.Next == null)
            {
                first.Next = second;
            }
            else
            {
                second.Next = first;
            }
            // reset two so you can't change the list using the old two reference
            two.Head = null;
            return one;
        }

        private static void DisplayList(LList toDisplay)
        {
            Node current = toDisplay.Head;

            while(current.Next != null)
            {
                Write(current.Value + ", ");
                current = current.Next;
            }
            WriteLine(current.Value);
        }
    }
}
