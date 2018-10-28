using System;
using System.Collections.Generic;
using System.Text;

namespace MaxStack.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public int Size { get; set; } = 0;
        public int Max { get; set; } = int.MinValue;

        /// <summary>
        /// Stack constructor
        /// </summary>
        /// <param name="node">The top stack to start</param>
        public Stack(Node node)
        {
            Top = node;
            Max = (int)node.Value;
            Size++;
        }

        /// <summary>
        /// Default constructor, used for creating an empty stack
        /// </summary>
        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// The peek method, returns what will be popped
        /// </summary>
        /// <returns>The node that will be popped</returns>
        public Node Peek()
        {
            // this is a great place for a try/catch (if you want)
            return Top;
        }

        /// <summary>
        /// Pops the top node
        /// </summary>
        /// <returns>Returns the top none and removes from stack</returns>
        public Node Pop()
        {
            if (Size > 0)
            {
                Size--;
            }
            else
            {
                Max = int.MinValue;
            }
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Adds a new node at the top
        /// </summary>
        /// <param name="node">The node that is added</param>
        public void Push(Node node)
        {
            if((int)node.Value > Max)
            {
                Max = (int)node.Value;
            }
            node.Next = Top;
            Top = node;
            Size++;
        }

        /// <summary>
        /// Returns the max int value of the stack
        /// </summary>
        /// <returns>The max value</returns>
        public int GetMax()
        {
            return Max;
        }
    }
}
