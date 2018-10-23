using System;
using System.Text;

namespace QueueWithStack.Classes
{
    
    public class Queue
    {
        // stacks that represent the Rear and Front
        public Stack Rear;
        public Stack Front;

        /// <summary>
        /// Constructor creates two empty stacks
        /// </summary>
        public Queue()
        {
            Rear = new Stack();
            Front = new Stack();
        }

        /// <summary>
        /// Pushes to the end of the Rear
        /// </summary>
        /// <param name="input">The node to input</param>
        public void Enqueue(Node input)
        {
            Rear.Push(input);
        }

        /// <summary>
        /// Returns the first node in
        /// </summary>
        /// <returns>A node that was the first node in the queue</returns>
        public Node Dequeue()
        {
            // pushes every item from Rear to Front
            while(Rear.Size > 0)
            {
                Front.Push(Rear.Pop());
            }

            // gets the Front of the queue
            Node result = Front.Pop();
            
            // pushes the items back in order
            while(Front.Size > 0)
            {
                Rear.Push(Front.Pop());
            }

            return result;
        }
    }
}
