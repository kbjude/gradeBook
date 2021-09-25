using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.8);
            book.AddGrade(77.6);
            book.AddGrade(56.8);
            book.AddGrade(45.6);

            //act

            var result = book.GetStatistics();

            //assert

            Assert.Equal(67.4, result.Average, 1);
            Assert.Equal(89.8, result.High, 1);
            Assert.Equal(45.6, result.Low, 1);
        }
    }
}
