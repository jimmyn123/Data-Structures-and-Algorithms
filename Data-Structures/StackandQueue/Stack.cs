using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public int Size { get; set; } = 0;

        public Stack(Node node)
        {
            Top = node;
            Size++;
        }

        // default constructor
        public Stack()
        {
            
        }

        //Peek
        public Node Peek()
        {
            // this is a great place for a try/catch (if you want)
            return Top;
        }

        //Pop
        public Node Pop()
        {
            Node temp = Peek();

            if (temp != null)
            {
                Top = Top.Next;
                temp.Next = null;
                Size--;
            }
            return temp;
        }
        //Push
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
            Size++;
        }
    }
}
