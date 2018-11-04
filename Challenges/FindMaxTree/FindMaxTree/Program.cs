using System;
using Trees.Classes;
using static System.Console;

namespace FindMaxTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create nodes and tree
            Node root = new Node(1);
            Node leftChild = new Node(3);
            Node rightChild = new Node(222);
            Node leftChildLeftChild = new Node(10000);
            Node rightChildLeftChild = new Node(32);

            root.Left = leftChild;
            root.Right = rightChild;
            leftChild.Left = leftChildLeftChild;
            rightChild.Left = rightChildLeftChild;

            BinaryTree bt = new BinaryTree(root);

            WriteLine("Created tree: 1, 3, 10000, 222, 32 in that pre-order.");
            WriteLine("Finding max value, which should be 10000.");
            WriteLine("Max value: " + FindMaxValue(bt));
        }

        /// <summary>
        /// Finds the max value with a bt input
        /// </summary>
        /// <param name="bt">The binary tree to traverse</param>
        /// <returns>the max value</returns>
        public static int FindMaxValue(BinaryTree bt)
        {
            return FindMaxValue(bt.Root, int.MinValue);
        }

        /// <summary>
        /// The actual recursive function that does the traversal
        /// </summary>
        /// <param name="curr">the current root to compare</param>
        /// <param name="max">the current max value</param>
        /// <returns>the max value</returns>
        private static int FindMaxValue(Node curr, int max)
        {
            // compares the values
            if((int)curr.Value > max)
            {
                max = (int)curr.Value;
            }

            // if there is something on the left compare to the left
            if(curr.Left != null)
            {
                max = FindMaxValue(curr.Left, max);
            }

            // if there is something on the right, figure out the max for the right
            if(curr.Right != null)
            {
                max = FindMaxValue(curr.Right, max);
            }
            
            // always return max at base case
            return max;
        }
    }
}
