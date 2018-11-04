using System;
using Trees.Classes;
using static System.Console;

namespace FindMaxTree
{
    class Program
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

        public static int FindMaxValue(BinaryTree bt)
        {
            return FindMaxValue(bt.Root, int.MinValue);
        }

        public static int FindMaxValue(Node curr, int max)
        {
            if((int)curr.Value > max)
            {
                max = (int)curr.Value;
            }
            if(curr.Left != null)
            {
                max = FindMaxValue(curr.Left, max);
            }
            if(curr.Right != null)
            {
                max = FindMaxValue(curr.Right, max);
            }
            return max;
        }
    }
}
