namespace BookWise.Domain.Entities;

public class Reader : Entity
{
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
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public int LoanAmount { get; private set; }
    public bool IsSuspended { get; private set; }
}
