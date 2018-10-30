using System;
using Trees.Classes;
using static System.Console;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new tree

            BinarySearchTree bst = new BinarySearchTree(new Node(77));
            bst.Add(new Node(15));
            bst.Add(new Node(3));
            bst.Add(new Node(56));
            bst.Add(new Node(110));
            bst.Add(new Node(90));
            bst.Add(new Node(117));

            // displays what was created and the expected output
            WriteLine("Created new tree in pre-order: 77, 15, 3, 56, 110, 90, 117");
            WriteLine("Should return 77 - FizzBuzz - Fizz - 56 - Buzz - FizzBuzz - Fizz");

            // calls fizzbuzz
            FizzBuzzTree(bst.Root);
        }

        /// <summary>
        /// Traverses the tree and replaces them with FizzBuzz, Fizz, or Buzz when necessary.
        /// </summary>
        /// <param name="root">The value to evaluate</param>
        public static void FizzBuzzTree(Node root)
        {
            int value = (int)root.Value;

            // tests each value to see if they are divisible
            if (value % 15 == 0)
            {
                WriteLine("FizzBuzz");
            }
            else if (value % 5 == 0)
            {
                WriteLine("Buzz");
            }
            else if( value %3 == 0)
            {
                WriteLine("Fizz");
            }
            else
            {
                WriteLine(value);
            }

            // if there are children node, traverse them
            if(root.Left != null)
            {
                FizzBuzzTree(root.Left);
            }

            if (root.Right != null)
            {
                FizzBuzzTree(root.Right);
            }
        }
    }
}
