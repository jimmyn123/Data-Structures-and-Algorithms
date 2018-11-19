using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class HashTable
    {
        public Node[] HashTableArray { get; set; }

        /// <summary>
        /// default constructor, defaults to 13 buckets
        /// </summary>
        public HashTable() : this(13)
        {
        }

        /// <summary>
        /// Makes a new array with n buckets
        /// </summary>
        /// <param name="buckets">the size of array</param>
        public HashTable(int buckets)
        {
            HashTableArray = new Node[buckets];
        }

        /// <summary>
        /// gets the index by hashing the string
        /// </summary>
        /// <param name="key">the key to hash</param>
        /// <returns>the index</returns>
        public UInt64 GetHash(string key)
        {
            UInt64 initial = 5381;
            UInt64 hashMultiplier = 33;

            UInt64 hash = initial;
            for(int i = 0; i < key.Length; i++)
            {
                hash = hash * hashMultiplier + (UInt64)key[i];
            }

            hash %= (UInt64)HashTableArray.Length;
            return hash;
        }

        /// <summary>
        /// adds the key value pair to the hashtable
        /// </summary>
        /// <param name="key">the string key</param>
        /// <param name="input">the value</param>
        public void Add(string key, object input)
        {
            UInt64 index = GetHash(key);

            // if the bucket is empty, set the first node
            if(HashTableArray[index] == null)
            {
                HashTableArray[index] = new Node(key, input);
            }
            else
            {
                Node curr = HashTableArray[index];
                Node prev = null;

                bool uniqueKey = true;

                // iterate through the list, if there is a match, replace the string with new value
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

                // if it is completely new, add to the end
                if (uniqueKey)
                {
                    prev.Next = new Node(key, input);
                }
            }
        }

        /// <summary>
        /// If the hashtable finds the key
        /// </summary>
        /// <param name="key">the key to search for</param>
        /// <returns>if the hashtable contains the key</returns>
        public bool Contains(string key)
        {
            return Find(key) != null;
        }

        /// <summary>
        /// Finds the key and returns the node
        /// </summary>
        /// <param name="key">the key to find</param>
        /// <returns>the value</returns>
        public object Find(string key)
        {
            UInt64 index = GetHash(key);

            Node curr = HashTableArray[index];

            // iterate through the table, return the value if the key is the same
            while (curr != null)
            {
                if (curr.Key == key)
                {
                    return curr.Value;
                }
                curr = curr.Next;
            }
            return null;
        }
    }
}
