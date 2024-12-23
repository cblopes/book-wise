using BookWise.Domain.Enums;

namespace BookWise.Domain.Entities;

public class Book : Entity
{
    private readonly List<Loan> _loans;

    public Book(
        string title,
        string author,
        ECategory category)
    {
        Title = title;
        Author = author;
        Category = category;
        IsAvailable = true;
        _loans = [];
    }

    public string Title { get; private set; }
    public string Author { get; private set; }
    public ECategory Category { get; private set; }
    public bool IsAvailable { get; private set; }

    public IReadOnlyCollection<Loan> Loans => _loans.AsReadOnly();

    public void MarkAsAvailable()
        => IsAvailable = true;

    public void MarkAsUnavailable()
        => IsAvailable = false;
}
