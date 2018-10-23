using System;
using System.Text;

namespace QueueWithStack.Classes
{
    
    public class Queue
    {
        Stack rear;
        Stack front;
        
        public Queue()
        {
            rear = new Stack();
            front = new Stack();
        }

        public void Enqueue(Node input)
        {
            rear.Push(input);
        }

        public Node Dequeue()
        {
            while(rear.Size > 0)
            {
                front.Push(rear.Pop());
            }

            Node result = front.Pop();
            
            while(front.Size > 0)
            {
                rear.Push(front.Pop());
            }

            return result;
        }
    }
}
