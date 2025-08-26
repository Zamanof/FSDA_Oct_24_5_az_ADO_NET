// Migrations
using StudentContext db = new();

List<Student> students = new()
{
    new Student()
    {
        FirstName = "Co",
        LastName = "Bayden",
        Age = 92
    },
    new Student()
    {
        FirstName = "Donald",
        LastName = "Tramp",
        Age = 22
    }
};

db.Students.AddRange(students);

db.SaveChanges();
