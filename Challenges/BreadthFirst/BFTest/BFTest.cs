using System;
using System.Collections.Generic;
using Trees.Classes;
using Xunit;
using static Breadth_First.Program;

namespace BFTest
{
    public class BFTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(7)]
        [InlineData(1)]
        public void TestBreadthFirst(int expected)
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

            // created binary tree abd called methods
            BinaryTree bt = new BinaryTree(root);
            List<Node> bfList = BreadthFirst(bt);

            Assert.Equal(expected, (int)bfList[expected-1].Value);
        }
    }
}
