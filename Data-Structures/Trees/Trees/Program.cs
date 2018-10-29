using System;
using Trees.Classes;
using static System.Console;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the tree
            Node root = new Node(1);
            Node leftChild = new Node(2);
            Node rightChild = new Node(3);
            Node LeftChildLeft = new Node(4);
            Node LeftChildRight = new Node(5);
            Node RightChildLeft = new Node(6);
            Node RightChildRight = new Node(7);
            root.Left = leftChild;
            root.Right = rightChild;
            leftChild.Left = LeftChildLeft;
            leftChild.Right = LeftChildRight;
            rightChild.Left = RightChildLeft;
            rightChild.Right = RightChildRight;

            BinaryTree bt = new BinaryTree(root);

            // Prints preorder
            WriteLine("======== Pre-order ========");
            bt.PreOrder();
            WriteLine("======== In-order ========");
            bt.InOrder();
            WriteLine("======== Post-order ========");
            bt.PostOrder();
        }
    }
}
