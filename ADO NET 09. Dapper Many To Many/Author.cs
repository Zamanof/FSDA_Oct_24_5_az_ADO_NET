// See https://aka.ms/new-console-template for more information

class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Book> Books { get; set; } = [];

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

