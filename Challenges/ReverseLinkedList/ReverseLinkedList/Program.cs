using System;
using Day06_LinkedList.Classes;
using static System.Console;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates linked list with values 1 -> 2 -> 3 -> 4 ->5
            LList input = new LList(new Node(5));
            input.Add(new Node(4));
            input.Add(new Node(3));
            input.Add(new Node(2));
            input.Add(new Node(1));

            // prints out linked list before reverse
            WriteLine("Array before reverse: ");
            input.Print();

            // prints out linked list after reverse
            WriteLine("Array after reverse: ");
            Reverse(input);
            input.Print();
        }

        /// <summary>
        /// Reverse method for linked list arrays
        /// </summary>
        /// <param name="input">The linked list to reverse</param>
        /// <returns>The reversed linked list</returns>
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
            input.Head = prev;
            return input;
        }
    }
}
