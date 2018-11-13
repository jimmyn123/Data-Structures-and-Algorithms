using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    class Hashtable
    {
        public LinkedList<Node>[] HashTableArray { get; set; }

        public Hashtable() : this(13)
        {
        }

        public Hashtable(int buckets)
        {
            HashTableArray = new LinkedList<Node>[buckets];
        }

        public int GetHash(string key)
        {
            int index = 0;
            foreach(char c in key)
            {
                index += (int)c;   
            }

            index *= 137;
            index %= HashTableArray.Length;
            return index;
        }

        public void Add(string key, Node input)
        {
            int index = GetHash(key);
            if(HashTableArray[index] == null)
            {
                LinkedList<Node> stored = new LinkedList<Node>();
                stored.AddLast(input);
                HashTableArray[index] = stored;
            }
            else
            {
                LinkedList<Node> stored = HashTableArray[index];
                foreach(Node curr in )
            }
        }
    }
}
