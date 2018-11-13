using System;
using Hashtable.Classes;
using static System.Console;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable();

            WriteLine("Created new hashtable....");
            Node initial = new Node("Cat", 15);

            WriteLine("Creating new node that has key: Cat and value: 15");
            WriteLine("After hash, Cat should have index: 10");
            WriteLine("Actual index: " + ht.GetHash(initial.Key));
        }
    }
}
