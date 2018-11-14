using System;
using Hashtable.Classes;
using static System.Console;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new hash table
            HashTable ht = new HashTable();

            // creates a node
            WriteLine("Created new hashtable....");
            Node initial = new Node("Cat", 15);

            // finds the hash of the string
            WriteLine("Creating new node that has key: Cat and value: 15");
            WriteLine("After hash, Cat should have index: 10");
            WriteLine("Actual index: " + ht.GetHash(initial.Key));

            // adds and tests contains
            ht.Add(initial.Key, initial);
            WriteLine("Contains Cat key: " + ht.Contains("Cat"));
        }
    }
}
