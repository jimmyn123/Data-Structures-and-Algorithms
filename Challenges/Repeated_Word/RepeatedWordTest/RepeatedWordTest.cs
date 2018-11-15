using System;
using Xunit;
using static Repeated_Word.Program;

namespace RepeatedWordTest
{
    public class RepeatedWordTest
    {
        /// <summary>
        /// Tests repeating words with expected
        /// </summary>
        /// <param name="input">the input string</param>
        /// <param name="word">the expected repeat</param>
        [Theory]
        [InlineData("The silver fox jumped over the moon.", "the")]
        [InlineData("I am a cloud ninja. The world class one", null)]
        [InlineData("I am a repeating sentence, maybe I will not repeat today.", "i")]
        public void TestRepeatWord(string input, string word)
        {
            string repeatedWord = RepeatedWord(input);
            Assert.Equal(word, repeatedWord);
        }
    }
}
