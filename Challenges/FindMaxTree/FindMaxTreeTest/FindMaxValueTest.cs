using System;
using Xunit;
using Trees.Classes;
using static FindMaxTree.Program;

namespace FindMaxTreeTest
{
    public class FindMaxValueTest
    {
        /// <summary>
        /// Adds N number of nodes with N value, tests to make sure the max is n
        /// </summary>
        /// <param name="max">The max value</param>
        [Theory]
        [InlineData(1000)]
        [InlineData(9999)]
        [InlineData(50)]
        public void FindMaxValueBTTest(int max)
        {
            Node root = new Node(1);
            Node curr = root;
            BinaryTree bt = new BinaryTree(root);

            // iterates through and adds a left child for n times
            for(int i = 2; i < max + 1; i++)
            {
                curr.Left = new Node(i);
                curr = curr.Left;
            }

            Assert.True(max == FindMaxValue(bt));
        }
    }
}
