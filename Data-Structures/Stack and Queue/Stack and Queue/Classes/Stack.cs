using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Stack constructor
        /// </summary>
        /// <param name="node">The top stack to start</param>
        public Stack(Node node)
        {
            Top = node;
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
            node.Next = Top;
            Top = node;
        }
    }
}
