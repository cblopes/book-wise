using BookWise.Domain.Entities;
using BookWise.Domain.Enums;

namespace BookWise.Tests.Entities;

public class ReaderTests
{
    [Fact]
    public void CanBorrowBook_ShouldReturnFalse_WhenReaderIsUnderageForNonChildishBook()
    {
        // Arrange
        var reader = new Reader("Bruce", "Wayne", DateTime.Today.AddYears(-10));
        var book = new Book("Title", "Author", ECategory.Terror);

        // Act
        var result = reader.CanBorrowBook(book);

        // Assert
        Assert.False(result, "Reader underage should not be able to borrow non-childish books.");
    }

    [Fact]
    public void CanBorrowBook_ShouldReturnFalse_WhenReaderIsSuspended()
    {
        // Arrange
        var reader = new Reader("Christhian", "Lopes", new DateTime(2001, 7, 16));
        var book = new Book("Harry Potter e a Pedra Filosofal", "J. K. Rowling", ECategory.Romance);
        reader.Suspend();

        // Act
        var result = reader.CanBorrowBook(book);

        // Assert
        Assert.False(result, "Reader suspended should be not able to borrow books.");
    }

    [Fact]
    public void CanBorrowBook_ShouldReturnTrue_WhenReaderMeetsCriteria()
    {
        // Arrange
        var reader = new Reader("Christhian", "Lopes", new DateTime(2001, 7, 16));
        var book = new Book("Harry Potter e a Pedra Filosofal", "J. K. Rowling", ECategory.Romance);

        // Act
        var result = reader.CanBorrowBook(book);

        // Assert
        Assert.True(result, "Reader meeting criteria should be able to borrow the book.");
    }
}
