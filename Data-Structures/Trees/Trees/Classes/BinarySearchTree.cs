using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Constructor with initial node
        /// </summary>
        /// <param name="root">Initial node</param>
        public BinarySearchTree(Node root)
        {
            Root = root;
        }
        
        public void add(Node toAdd)
        {
            Node curr = Root;
            while(curr != null)
            {
                if((int)toAdd.Value < (int)curr.Value)
                {
                    if(curr.Left != null)
                    {
                        curr = curr.Left;
                    }
                    else
                    {
                        curr.Left = toAdd;
                    }
                }
                else
                {
                    if(curr.Right != null)
                    {
                        curr = curr.Right;
                    }
                    else
                    {
                        curr.Right = toAdd;
                    }
                }
            }
        }
    }
}
