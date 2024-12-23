using BookWise.Domain.Enums;

namespace BookWise.Domain.Entities;

public class Reader : Entity
{
    private readonly List<Loan> _loans;

    public Reader(
        string firstName,
        string lastName,
        DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate.Date;
        IsSuspended = false;
        _loans = [];
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public bool IsSuspended { get; private set; }

    public IReadOnlyCollection<Loan> Loans => _loans.AsReadOnly();

    public bool CanBorrowBook(Book book)
    {
        if (GetAge() < 18 && book.Category != ECategory.Childish)
            return false;

        if (GetLoansQuantityWithoutReturn() >= 5)
            return false;

        if (IsSuspended) return false;

        return true;
    }

    public void Suspend()
        => IsSuspended = true;

    public void Reinstate()
        => IsSuspended = false;

    private int GetAge()
        => Convert.ToInt32(DateTime.Today.Subtract(BirthDate).TotalDays / 365);

    private int GetLoansQuantityWithoutReturn()
        => _loans.Count(x => x.ReturnDate is null);
}
