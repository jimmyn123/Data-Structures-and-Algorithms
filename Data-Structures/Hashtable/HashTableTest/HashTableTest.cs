using System;
using Xunit;
using Hashtable.Classes;

namespace HashTableTest
{
    public class HashTableTest
    {
        /// <summary>
        /// Tests adding to the hashtable
        /// </summary>
        /// <param name="key">the key to add</param>
        /// <param name="value">the value to add</param>
        [Theory]
        [InlineData("First", 5)]
        [InlineData("Second", 13)]
        [InlineData("Third", 27)]
        public void TestAddingToHashTable(string key, int value)
        {
            HashTable ht = new HashTable();
            ht.Add(key, new Node(key, value));

            Assert.True(ht.Contains(key));
        }

        /// <summary>
        /// Tests the contains method
        /// </summary>
        /// <param name="key">the key to find</param>
        /// <param name="found">the expected result</param>
        [Theory]
        [InlineData("Cat", true)]
        [InlineData("Dog", true)]
        [InlineData("Third", false)]
        public void TestContainsHashTable(string key, bool found)
        {
            HashTable ht = new HashTable();
            ht.Add("Cat", new Node("Cat", 12));
            ht.Add("Dog", new Node("Dog", 27));

            Assert.True(ht.Contains(key) ==  found);
        }
        
        /// <summary>
        /// Tests the hash
        /// </summary>
        /// <param name="key">they key to has</param>
        [Theory]
        [InlineData("First")]
        [InlineData("Second")]
        [InlineData("Third")]
        public void TestGetHash(string key)
        {
            HashTable ht = new HashTable(17);
            int index = 0;

            for(int i = 0; i < key.Length; i++)
            {
                index += (int)key[i];
            }
            Assert.True((index * 137) % 17 == ht.GetHash(key));
        }

        /// <summary>
        /// Tests the find method
        /// </summary>
        /// <param name="key">the key to find</param>
        /// <param name="found">the expected result</param>
        [Theory]
        [InlineData("Cat", true)]
        [InlineData("Dog", true)]
        [InlineData("Third", false)]
        public void TestFindHashTable(string key, bool found)
        {
            HashTable ht = new HashTable();
            ht.Add("Cat", new Node("Cat", 50));
            ht.Add("Dog", new Node("Dog", 97));

            Assert.True((ht.Find(key) != null) == found);
        }
    }
}
