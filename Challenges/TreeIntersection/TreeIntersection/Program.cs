using System;
using Trees.Classes;
using Hashtable.Classes;
using System.Collections.Generic;
using static System.Console;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Creating BT1: 1, 7, 10, 2");

            // creating nodes
            Trees.Classes.Node one = new Trees.Classes.Node(1);
            Trees.Classes.Node seven = new Trees.Classes.Node(7);
            Trees.Classes.Node ten = new Trees.Classes.Node(10);
            Trees.Classes.Node two = new Trees.Classes.Node(2);

            one.Left = seven;
            seven.Right = ten;
            one.Right = two;

            BinaryTree bt1 = new BinaryTree(one);

            // create second tree
            Trees.Classes.Node two2 = new Trees.Classes.Node(2);
            Trees.Classes.Node seven2 = new Trees.Classes.Node(7);
            Trees.Classes.Node nine2 = new Trees.Classes.Node(9);

            two2.Left = seven2;
            two2.Right = nine2;

            BinaryTree bt2 = new BinaryTree(two2);

            WriteLine("Running tree intersect, should return: 2, 7");
            
            // loops through the returned list to show answer
            foreach(string returned in TreeIntersection(bt1, bt2))
            {
                WriteLine(returned);
            }

        }

        /// <summary>
        /// Method that returns a list of the values that intersect between the two trees
        /// </summary>
        /// <param name="bt1">First binary tree</param>
        /// <param name="bt2">Second binary tree</param>
        /// <returns>List of intersects</returns>
        public static List<string> TreeIntersection(BinaryTree bt1, BinaryTree bt2)
        {
            HashTable ht = new HashTable();
            List<string> returnValues = new List<string>();

            foreach(Trees.Classes.Node item in bt1.PreOrder())
            {
                ht.Add(item.Value.ToString(), item);
            }

            foreach(Trees.Classes.Node item in bt2.PreOrder())
            {
                string value = item.Value.ToString();
                if (ht.Contains(value))
                {
                    returnValues.Add(value);
                }
            }

            return returnValues;
        }
    }
}
