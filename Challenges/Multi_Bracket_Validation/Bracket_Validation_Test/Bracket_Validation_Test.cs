using System;
using Xunit;
using static Multi_Bracket_Validation.Program;

namespace Bracket_Validation_Test
{
    public class Bracket_Validation_Test
    {
        /// <summary>
        ///  Tests each case with the input and expected result
        /// </summary>
        /// <param name="input">string to test</param>
        /// <param name="expected">the expected boolean</param>
        [Theory]
        [InlineData(@"aa[[", false)]
        [InlineData(@"[a[{}]]", true)]
        [InlineData(@"aa{[]}", true)]
        public void BracketValidationTest(string input, bool expected)
        {
            Assert.True(MultiBracketValidation(input) == expected);
        }
    }
}
