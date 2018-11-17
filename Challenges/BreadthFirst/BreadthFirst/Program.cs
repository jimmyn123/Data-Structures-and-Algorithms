using System;
using Trees.Classes;
using System.Collections.Generic;
using static System.Console;

namespace Breadth_First
{
    public class Program
    {
        static void Main(string[] args)
        {
            // created node and attached children.
            Node root = new Node(1);
            Node leftChild = new Node(2);
            Node rightChild = new Node(3);
            Node leftChildLeftChild = new Node(4);
            Node leftChildRightChild = new Node(5);
            Node rightChildLeftChild = new Node(6);
            Node rightChildRightChild = new Node(7);
            root.Left = leftChild;
            root.Right = rightChild;
            leftChild.Left = leftChildLeftChild;
            leftChild.Right = leftChildRightChild;
            rightChild.Left = rightChildLeftChild;
            rightChild.Right = rightChildRightChild;

            WriteLine("added values, 1, 2, 3, 4, 5, 6, 7 to tree. Should display the same.");

            // created binary tree abd called methods
            BinaryTree bt = new BinaryTree(root);
            BreadthFirst(bt);

        }

        /// <summary>
        /// Does a breadth first traversal over binary tree
        /// </summary>
        /// <param name="bt">the binary tree</param>
        public static List<Node> BreadthFirst(BinaryTree bt)
        {
            // creats a new queue and adds the initial root node
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(bt.Root);

            List<Node> returnList = new List<Node>();

            // while the q is not empty
            while (q.Peek() != null)
            {
                // dequeue the root and then print the value and enqueue children.
                Node root = q.Dequeue();
                q.Enqueue(root.Left);
                q.Enqueue(root.Right);

                WriteLine(root.Value);
                returnList.Add(root);
            }

            return returnList;
        }
    }
}
