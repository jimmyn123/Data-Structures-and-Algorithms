using System;
using Xunit;
using static Unique_Characters.Program;

namespace Unique_Characters_test
{
    public class UniqueCharactersTest
    {
        /// <summary>
        /// Test the unique characters in string
        /// </summary>
        /// <param name="input">the string input</param>
        /// <param name="expected">the expected result</param>
        [Theory]
        [InlineData("abcdef", true)]
        [InlineData("abcdefc", false)]
        [InlineData("Cat", true)]
        public void UniqueTest(string input, bool expected)
        {
            bool result = UniqueCharacters(input);

            Assert.True(result == expected);
        }
    }
}
