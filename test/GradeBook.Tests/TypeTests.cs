using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private int GetInt()
        {
            return 3;
        }

        void SetInt(ref int y)
        {
            y = 42;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // arrange section
            var book1 = GetBook("Book 1");

            // act section
            GetBookSetName(ref book1, "New Name");

            // assert section
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange section
            var book1 = GetBook("Book 1");

            // act section
            GetBookSetName(book1, "New Name");

            // assert section
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange section
            var book1 = GetBook("Book 1");

            // act section
            SetName(book1, "New Name");

            // assert section
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Ryan";
            var upper = MakeUppercase(name);

            Assert.Equal("Ryan", name);
            Assert.Equal("RYAN", upper);
        }

        string MakeUppercase(string parameter)
        {
           return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange section
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            // act section
            

            // assert section
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanRefSameObject()
        {
            // arrange section
            var book1 = GetBook("Book 1");
            var book2 = book1;
            // act section
            

            // assert section
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

        void SetName(Book book, string name)
        {
            book.Name = name;
        }

        void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
    }
}
