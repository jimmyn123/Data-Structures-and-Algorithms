using System;
using System.Text;
using Stack_and_Queue.Classes;

namespace QueueWithStack.Classes
{
    
    public class Queue
    {
        Stack rear;
        Stack front;

        public int size { get; set; } = 0;
        public Queue()
        {
            rear = new Stack();
            front = new Stack();
        }

        public void Enqueue(Node input)
        {

        }
    }
}
