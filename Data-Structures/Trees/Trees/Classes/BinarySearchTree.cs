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
        
        /// <summary>
        /// Loops through with a while loop and then adds the nodes in the appropriate places
        /// </summary>
        /// <param name="toAdd"></param>
        public void Add(Node toAdd)
        {
            Node curr = Root;
            while(curr != null)
            {
                if((int)toAdd.Value < (int)curr.Value)
                {
                    // if the value is less than node should be on the left
                    if(curr.Left != null)
                    {
                        curr = curr.Left;
                    }
                    else
                    {
                        // resets curren to null to break loop, can use a break here too
                        curr.Left = toAdd;
                        curr = null;
                    }
                }
                else
                {
                    // else it should be added on the right
                    if(curr.Right != null)
                    {
                        curr = curr.Right;
                    }
                    else
                    {
                        curr.Right = toAdd;
                        curr = null;
                    }
                }
            }
        }

        public Node Search(int value)
        {
            Node curr = Root;

            while(curr != null)
            {
                if(value == (int)curr.Value)
                {
                    return curr;
                }
                if(value < (int)curr.Value)
                {
                    curr = curr.Left;
                }
                else
                {
                    curr = curr.Right;
                }
            }

            return null;
        }
    }
}
