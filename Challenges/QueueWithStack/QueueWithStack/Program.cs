﻿using System;
using static System.Console;
using QueueWithStack.Classes;

namespace QueueWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithStacks();
        }

        /// <summary>
        /// Adds 3 nodes and tests it
        /// </summary>
        private static void QueueWithStacks()
        {
            // Addes 3 nodes to a new Queue
            WriteLine("Adding 1,2,3 in that order");
            Queue q = new Queue();

            q.Enqueue(new Node(1));
            q.Enqueue(new Node(2));
            q.Enqueue(new Node(3));

            // Dequeues 3 times and displays the contents
            WriteLine("Dequeueing last node added...");
            WriteLine("Node dequeued: " + (int)q.Dequeue().Value);

            WriteLine("Dequeueing last node added...");
            WriteLine("Node dequeued: " + (int)q.Dequeue().Value);

            WriteLine("Dequeueing last node added...");
            WriteLine("Node dequeued: " + (int)q.Dequeue().Value);
        }
    }
}