// See https://aka.ms/new-console-template for more information
class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int IdGroup { get; set; }
    public int Term { get; set; }
    public virtual Group Group { get; set; }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Group.Name}";
    }
}
