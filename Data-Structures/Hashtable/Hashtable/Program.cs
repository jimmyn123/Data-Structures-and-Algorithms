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

            // finds the hash of the string
            WriteLine("After hash, Cat should have index: 10");
            WriteLine("Actual index: " + ht.GetHash("Cat"));

            // adds and tests contains
            ht.Add("Cat", 15);
            WriteLine("Contains Cat key: " + ht.Contains("Cat"));

            ht.Add("aCt", 17);
            WriteLine("Forced a collision using key aCt");
            
            WriteLine("Value of Cat should be 15");
            WriteLine("Value of finding Cat is: " + (int)ht.Find("Cat"));
            WriteLine("Value of aCt should be 17");
            WriteLine("Value of finding aCt is: " + (int)ht.Find("aCt"));
        }
    }
}
