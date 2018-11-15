using Hashtable.Classes;
using System;
using static System.Console;

namespace Repeated_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            // created the phrases
            string input = "The silver fox jumped over the moon.";
            string repeatedWord = RepeatedWord(input);

            WriteLine("Testing the following phrase for repeats");
            WriteLine("================");
            WriteLine("The silver fox jumped over the moon.");
            WriteLine("================");

            WriteLine("Repeated word is: " + repeatedWord);
        }

        /// <summary>
        /// returns the repeated word, ignoring case
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>The repeated word</returns>
        public static string RepeatedWord(string input)
        {
            HashTable ht = new HashTable();

            // split the string
            string[] words = input.Split(' ');

            foreach(string word in words)
            {
                // ignore case
                string lowerWord = word.ToLower();
                if (ht.Contains(lowerWord))
                {
                    return lowerWord;
                }
                else
                {
                    ht.Add(lowerWord, word);
                }
            }

            return null;
        }
    }
}
