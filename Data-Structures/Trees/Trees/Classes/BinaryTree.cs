using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> returnList;
        
        /// <summary>
        /// Creates a binary tree with a root node
        /// </summary>
        /// <param name="root">the root node</param>
        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Returns a list of in order elements
        /// </summary>
        /// <returns>List that of pre-ordered elements</returns>
        public List<Node> PreOrder()
        {
            returnList = new List<Node>();
            PreOrderRecursive(Root);
            return returnList;
        }

        /// <summary>
        /// The actual recursive method
        /// </summary>
        /// <param name="root">the current node</param>
        public void PreOrderRecursive(Node root)
        {
            Console.WriteLine((int)root.Value);
            returnList.Add(root);

            if (root.Left != null)
            {
                PreOrderRecursive(root.Left);
            }

            if (root.Right != null)
            {
                PreOrderRecursive(root.Right);
            }
        }

        /// <summary>
        /// Returns an in order representation of the elements in a list
        /// </summary>
        /// <returns>The list that contains all of the nodes in order</returns>
        public List<Node> InOrder()
        {
            returnList = new List<Node>();
            InOrderRecursive(Root);
            return returnList;
        }

        /// <summary>
        /// The actual recursive method for in order
        /// </summary>
        /// <param name="root">The starting node</param>
        public void InOrderRecursive(Node root)
        {
            if (root.Left != null)
            {
                PreOrderRecursive(root.Left);
            }

            Console.WriteLine((int)root.Value);
            returnList.Add(root);

            if (root.Right != null)
            {
                PreOrderRecursive(root.Right);
            }
        }

        /// <summary>
        /// Returns the post order of all of the elements in the node into a list
        /// </summary>
        /// <returns>The list of post order nodes</returns>
        public List<Node> PostOrder()
        {
            returnList = new List<Node>();
            PostOrderRecursive(Root);
            return returnList;
        }

        /// <summary>
        /// The actual recursive method for post order
        /// </summary>
        /// <param name="root">the starting node</param>
        public void PostOrderRecursive(Node root)
        {
            if (root.Left != null)
            {
                PostOrderRecursive(root.Left);
            }

            if (root.Right != null)
            {
                PostOrderRecursive(root.Right);
            }

            Console.WriteLine((int)root.Value);
            returnList.Add(root);
        }
    }
}
