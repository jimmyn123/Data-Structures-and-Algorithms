using Hashtable.Classes;
using System;
using static System.Console;

namespace Unique_Characters
{
    public class Program
    {
        static void Main(string[] args)
        {
            // tests first string, returns not unique
            bool testString = UniqueCharacters("abcdefc");
            WriteLine("Testing string: abcdefc");
            WriteLine("Should return False: " +testString);

            // tests second string, returns unique
            bool testString2 = UniqueCharacters("abcdef");
            WriteLine("Testing string: abcdef");
            WriteLine("Should return True: " + testString2);
        }

        /// <summary>
        /// Returns if a string input is unique or not
        /// </summary>
        /// <param name="input">the input string</param>
        /// <returns>whether the string is unique</returns>
        public static bool UniqueCharacters(string input)
        {
            input = input.ToLower();
            HashTable ht = new HashTable();
            foreach(char c in input)
            {
                if (ht.Contains(c.ToString()))
                {
                    return false;
                }
                ht.Add(c.ToString(), c);
            }
            return true;
        }
    }
}
