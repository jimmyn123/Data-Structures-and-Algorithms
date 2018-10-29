using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

namespace TreesTest
{
    public class TreesTest
    {
        /// <summary>
        /// Tests preorder
        /// </summary>
        /// <param name="expected">expected result</param>
        /// <param name="in1">int 1 to add</param>
        /// <param name="in2">int 2 to add</param>
        /// <param name="in3">int 3 to add</param>
        [Theory]
        [InlineData(new int[] {1,2,3}, 1, 2, 3)]
        [InlineData(new int[] {3,2,1}, 3, 2, 1)]
        [InlineData(new int[] {45,90,3}, 45, 90, 3)]
        public void BinaryTreePreOrderTest(int[] expected, int in1, int in2, int in3)
        {
            // Creates new nodes and adds them in that order
            Node root = new Node(in1);
            Node leftChild = new Node(in2);
            Node rightChild = new Node(in3);

            root.Left = leftChild;
            root.Right = rightChild;

            // creates a new binary tree
            BinaryTree bt = new BinaryTree(root);

            bool result = true;

            // gets the preorder
            List<Node> listBack = bt.PreOrder();

            // compares to the expected
            for(int i = 0; i < expected.Length; i++)
            {
                if(expected[i] != (int)listBack[i].Value)
                {
                    result = false;
                }
            }

            Assert.True(result);
        }

        /// <summary>
        /// Tests ineorder
        /// </summary>
        /// <param name="expected">expected result</param>
        /// <param name="in1">int 1 to add</param>
        /// <param name="in2">int 2 to add</param>
        /// <param name="in3">int 3 to add</param>
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2, 1, 3)]
        [InlineData(new int[] { 3, 2, 1 }, 2, 3, 1)]
        [InlineData(new int[] { 45, 90, 3 }, 90, 45, 3)]
        public void BinaryTreeInOrderTest(int[] expected, int in1, int in2, int in3)
        {
            // Creates new nodes and adds them in that order
            Node root = new Node(in1);
            Node leftChild = new Node(in2);
            Node rightChild = new Node(in3);

            root.Left = leftChild;
            root.Right = rightChild;

            // creates a new binary tree
            BinaryTree bt = new BinaryTree(root);

            bool result = true;

            // gets the preorder
            List<Node> listBack = bt.InOrder();

            // compares to the expected
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != (int)listBack[i].Value)
                {
                    result = false;
                }
            }

            Assert.True(result);
        }

        /// <summary>
        /// Tests postorder
        /// </summary>
        /// <param name="expected">expected result</param>
        /// <param name="in1">int 1 to add</param>
        /// <param name="in2">int 2 to add</param>
        /// <param name="in3">int 3 to add</param>
        [Theory]
        [InlineData(new int[] { 2, 3, 1 }, 1, 2, 3)]
        [InlineData(new int[] { 2, 1, 3 }, 3, 2, 1)]
        [InlineData(new int[] { 3, 45, 90 }, 90, 3, 45)]
        public void BinaryTreePostOrderTest(int[] expected, int in1, int in2, int in3)
        {
            // Creates new nodes and adds them in that order
            Node root = new Node(in1);
            Node leftChild = new Node(in2);
            Node rightChild = new Node(in3);

            root.Left = leftChild;
            root.Right = rightChild;

            // creates a new binary tree
            BinaryTree bt = new BinaryTree(root);

            bool result = true;

            // gets the preorder
            List<Node> listBack = bt.PostOrder();

            // compares to the expected
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != (int)listBack[i].Value)
                {
                    result = false;
                }
            }

            Assert.True(result);
        }

        /// <summary>
        /// Compares the left or right node according to the order added
        /// </summary>
        /// <param name="input">The values to add</param>
        [Theory]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 190, 67 })]
        [InlineData(new int[] { 9999, 13 })]
        public void BSTAddTest(int[] input)
        {
            // creates new root and new BST
            Node root = new Node(input[0]);

            BinarySearchTree bst = new BinarySearchTree(root);
            bst.Add(new Node(input[1]));

            bool testResult;
            
            // tests if the nodes were added to the proper places
            if (input[1] > input[0])
            {
                testResult = (root.Right != null);
            }
            else
            {
                testResult = (root.Left != null);
            }

            Assert.True(testResult);
        }

        [Theory]
        [InlineData(new int[] { 1,2,3}, 3, true)]
        [InlineData(new int[] { 1,2,3}, 5, false)]
        [InlineData(new int[] { 999,37,438, 50, 33, 22, 171}, 50, true)]
        public void BSTSearchTest(int[] input, int search, bool expected)
        {
            BinarySearchTree bst = new BinarySearchTree(new Node(input[0]));
            for(int i = 1; i < input.Length; i++)
            {
                bst.Add(new Node(input[i]));
            }
            Assert.True((bst.Search(search) != null) == expected);
        }
    }
}
