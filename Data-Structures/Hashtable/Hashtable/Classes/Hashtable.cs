using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    class HashTable
    {
        public Node[] HashTableArray { get; set; }

        public HashTable() : this(13)
        {
        }

        public HashTable(int buckets)
        {
            HashTableArray = new Node[buckets];
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

        public void Add(string key, object input)
        {
            int index = GetHash(key);
            if(HashTableArray[index] == null)
            {
                HashTableArray[index] = new Node(key, input);
            }
            else
            {
                Node curr = HashTableArray[index];
                Node prev = null;

                bool uniqueKey = true;

                while(curr != null)
                {
                    if(curr.Key == key)
                    {
                        curr.Value = input;
                        uniqueKey = false;
                    }
                    prev = curr;
                    curr = curr.Next;
                }

                if (uniqueKey)
                {
                    prev.Next = new Node(key, input);
                }
            }
        }

        public bool Contains(string key)
        {
            return Find(key) != null;
        }

        public Node Find(string key)
        {
            int index = GetHash(key);

            Node curr = HashTableArray[index];
            while (curr != null)
            {
                if (curr.Key == key)
                {
                    return curr;
                }
            }
            return null;
        }
    }
}
