using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> returnList;
        
        public BinaryTree(Node root)
        {
            Root = root;
        }

        public List<Node> PreOrder()
        {
            returnList = new List<Node>();
            PreOrderRecursive(Root);
            return returnList;
        }

        public void PreOrderRecursive(Node root)
        {
            Console.WriteLine((int)root.Value);
            returnList.Add(Root);

            if (root.Left != null)
            {
                PreOrderRecursive(root.Left);
            }

            if (root.Right != null)
            {
                PreOrderRecursive(root.Right);
            }
        }

        public List<Node> InOrder()
        {
            returnList = new List<Node>();
            InOrderRecursive(Root);
            return returnList;
        }

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

        public List<Node> PostOrder()
        {
            returnList = new List<Node>();
            PostOrderRecursive(Root);
            return returnList;
        }

        public void PostOrderRecursive(Node root)
        {
            if (root.Left != null)
            {
                PreOrderRecursive(root.Left);
            }

            if (root.Right != null)
            {
                PreOrderRecursive(root.Right);
            }

            Console.WriteLine((int)root.Value);
            returnList.Add(root);
        }
    }
}
