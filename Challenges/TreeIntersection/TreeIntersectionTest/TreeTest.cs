using System;
using Trees.Classes;
using Xunit;
using static TreeIntersectionChallenge.Program;

namespace TreeIntersectionTest
{
    public class TreeTest
    {
        /// <summary>
        /// tests two intersections in binary tree
        /// </summary>
        [Fact]
        public void TestTwoIntersections()
        {
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

            Assert.True(TreeIntersection(bt1, bt2).Count == 2);
        }

        /// <summary>
        /// tests one intersections in binary tree
        /// </summary>
        [Fact]
        public void TestOneIntersections()
        {
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
            Trees.Classes.Node eight2 = new Trees.Classes.Node(8);
            Trees.Classes.Node nine2 = new Trees.Classes.Node(9);

            two2.Left = eight2;
            two2.Right = nine2;

            BinaryTree bt2 = new BinaryTree(two2);

            Assert.True(TreeIntersection(bt1, bt2).Count == 1);
        }

        /// <summary>
        /// tests no intersections in binary tree
        /// </summary>
        [Fact]
        public void TestNoIntersections()
        {
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
            Trees.Classes.Node four2 = new Trees.Classes.Node(4);
            Trees.Classes.Node eight2 = new Trees.Classes.Node(8);
            Trees.Classes.Node nine2 = new Trees.Classes.Node(9);

            four2.Left = eight2;
            four2.Right = nine2;

            BinaryTree bt2 = new BinaryTree(four2);

            Assert.True(TreeIntersection(bt1, bt2).Count == 0);
        }
    }
}
