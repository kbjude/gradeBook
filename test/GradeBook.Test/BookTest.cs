using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var x = 5;
            var y = 2;
            var expected = 7;
            var actual = x + y;

            Assert.Equal(expected, actual);
        }
    }
}
