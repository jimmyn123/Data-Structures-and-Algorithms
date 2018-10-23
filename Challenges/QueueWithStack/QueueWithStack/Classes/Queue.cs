using System;
using System.Text;
using Stack_and_Queue.Classes;

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
            rear.Size++;
        }

        public Node Dequeue()
        {
            int size = rear.Size;
            while(size > 0)
            {
                front.Push(rear.Pop());
                size--;
            }

            Node result = front.Pop();
            size = --rear.Size;
            
            while(size > 0)
            {
                rear.Push(front.Pop());
            }

            return result;   
        }
    }
}
