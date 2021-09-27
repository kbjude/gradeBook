using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTest
    {
        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test2()
        {
            var x = Getint();
            SetInt(ref x);


            Assert.Equal(44, x);

            //arrange(PAssing parameter by value... taking the value in one variable and placing it in another parameter)

            //act

            //assert

        }

        private void SetInt(ref int z)
        {
            z = 44;
        }

        private int Getint()
        {
            return 3;
        }


        [Fact]
        public void Test1()
        {
            //arrange(PAssing parameter by value... taking the value in one variable and placing it in another parameter)

            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);

            //act

            //assert

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }


        [Fact]
        public void CanSetBookNameFromReference()
        {
            //arrange(Passing parameter by value... taking the value in one variable and placing it in another parameter)

            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

            //act

            //assert

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
            //act

            //assert

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange

            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            //act

            //assert

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }


    }
}
