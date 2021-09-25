using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        {
            //arrange

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            //act

            //assert

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }


    }
}
