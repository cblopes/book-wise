using BookWise.Domain.Enums;

namespace BookWise.Domain.Entities;

public class Book : Entity
{
    public Book(
        string title,
        string author,
        ECategory category)
    {
        Title = title;
        Author = author;
        Category = category;
        IsAvailable = true;
    }

    public string Title { get; private set; }
    public string Author { get; private set; }
    public ECategory Category { get; private set; }
    public bool IsAvailable { get; private set; }
}
