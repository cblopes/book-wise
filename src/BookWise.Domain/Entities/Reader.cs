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
        LoanAmount = 0;
        IsSuspended = false;
        _loans = [];
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public int LoanAmount { get; private set; }
    public bool IsSuspended { get; private set; }

    public IReadOnlyCollection<Loan> Loans => [.. _loans];
}
