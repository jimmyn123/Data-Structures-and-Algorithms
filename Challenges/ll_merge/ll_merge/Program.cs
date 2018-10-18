using System;
using Day06_LinkedList.Classes;
using static System.Console;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Creates new list one with values: [1] -> [3]
            LList one = new LList(new Node(3));
            one.Add(new Node(1));

            // Creates new list two with values: [2] -> [4] -> [5] -> [6]
            LList two = new LList(new Node(6));
            two.Add(new Node(5));
            two.Add(new Node(4));
            two.Add(new Node(2));

            // Displays the first list
            WriteLine("List one has the following values: ");
            DisplayList(one);

            // Displays the second list
            WriteLine("List two has the following values: ");
            DisplayList(two);
            
            // Merges the two lists and displays them
            LList merged = merge(one, two);
            WriteLine("After merging, list should be 1, 2, 3, 4, 5, 6");

            WriteLine("Actual");
            DisplayList(merged);
        }

        /// <summary>
        /// Merges two lists and returns one list of the merged list. The original lists are destroyed
        /// </summary>
        /// <param name="one">first list to merge</param>
        /// <param name="two">second list to merge</param>
        /// <returns></returns>
        public static LList merge(LList one, LList two)
        {
            // creates the two pointers
            Node first = one.Head;
            Node second = two.Head;

            // loops while neither is null
            while(first.Next != null && second.Next != null)
            {
                // stores the next of each current into temp variables
                Node nextFirst = first.Next;
                Node nextSecond = second.Next;

                // switches to the appropriate references
                first.Next = second;
                second.Next = nextFirst;

                // resets the points to the correct currents
                first = nextFirst;
                second = nextSecond;
            }

            // sets the rest of the list
            if(first.Next == null)
            {
                first.Next = second;
            }
            else
            {
                second.Next = first;
            }
            // reset two so you can't change the list using the old references
            two.Head = null;
            return one;
        }

        /// <summary>
        /// Writes out the contents of the list
        /// </summary>
        /// <param name="toDisplay">The list to display</param>
        private static void DisplayList(LList toDisplay)
        {
            Node current = toDisplay.Head;

            // loops through and writes all of the values except the last
            while(current.Next != null)
            {
                Write(current.Value + ", ");
                current = current.Next;
            }

            // writes the last value
            WriteLine(current.Value);
        }
    }
}
