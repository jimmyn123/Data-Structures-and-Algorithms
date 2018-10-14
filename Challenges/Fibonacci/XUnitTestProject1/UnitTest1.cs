using System;
using Xunit;
using static Fibonacci.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(8, 21)]
        [InlineData(14, 377)]
        public void FibonacciTest(int n, int expected)
        {
            Assert.True(expected == FindNth(n));
        }
    }
}
