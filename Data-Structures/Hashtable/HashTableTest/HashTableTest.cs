using System;
using Xunit;
using Hashtable.Classes;

namespace HashTableTest
{
    public class HashTableTest
    {
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
    }
}
