// Read releational datas

// + Eager loading
// - Explicit loading
// - Lazy loading
class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int GroupId { get; set; } // Foreign key
    public Group Group { get; set; } // Navigation property

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}
