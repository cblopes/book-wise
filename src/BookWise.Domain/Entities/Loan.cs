namespace BookWise.Domain.Entities;

public class Loan : Entity
{
    public Loan(
        Reader reader,
        Book book)
    {
        Reader = reader;
        Book = book;
        LoanDate = DateTime.Now.Date;
    }

    public DateTime LoanDate { get; private set; }
    public DateTime? ReturnDate { get; private set; }

    public int ReaderId { get; private set; }
    public Reader Reader { get; private set; } = null!;

    public int BookId { get; private set; }
    public Book Book { get; private set; } = null!;
}
