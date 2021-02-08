using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateStats()
        {
            // arrange section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(-5.1); //should not add and should not be the low value.
            book.AddGrade(105.0); //should not add and should not be the high value.
            book.AddGrade(88.9);

            // act section
            var result = book.GetStatistics();

            // assert section
            Assert.Equal(89.0, result.Average, 1);
            Assert.Equal(89.1, result.High, 1);
            Assert.Equal(88.9, result.Low, 1);
        }
    }
}
