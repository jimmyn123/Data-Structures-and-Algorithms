using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

namespace TreesTest
{
    public class TreesTest
    {
        [Theory]
        [InlineData(new int[] {1,2,3}, 1, 2, 3)]
        [InlineData(new int[] {3,2,1}, 3, 2, 1)]
        [InlineData(new int[] { 45, 90, 3 }, 45, 90, 3)]
        public void BinaryTreePreOrderTest(int[] expected, int in1, int in2, int in3)
        {
            Node root = new Node(in1);
            Node leftChild = new Node(in2);
            Node rightChild = new Node(in3);

            root.Left = leftChild;
            root.Right = rightChild;

            BinaryTree bt = new BinaryTree(root);

            bool result = true;

            List<Node> listBack = bt.PreOrder();
            for(int i = 0; i < expected.Length; i++)
            {
                if(expected[i] != (int)listBack[i].Value)
                {
                    result = false;
                }
            }

            Assert.True(result);
        }
    }
}
