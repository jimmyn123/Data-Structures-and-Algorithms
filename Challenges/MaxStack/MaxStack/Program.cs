using System;
using MaxStack.Classes;
using static System.Console;

namespace MaxStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a new stack with 3 elements
            Stack newStack = new Stack(new Node(100));
            newStack.Push(new Node(390));
            newStack.Push(new Node(251));

            // tests the get stack
            WriteLine("Creating new stack with numbers: 251, 390, 100");
            WriteLine("Finding max, should be 390.\n Max: " + newStack.GetMax());
        }
    }
}
