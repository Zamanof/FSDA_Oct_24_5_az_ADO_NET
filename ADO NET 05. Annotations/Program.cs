// Annotations
using SchoolContext db = new();

Student student = new()
{
    FirstName = "Qafar",
    LastName = "Qafarzade"
};

db.Students.Add(student);

Group group = new Group()
{
    GroupName = "FSDA_Oct_24_5_az",
    GroupRating = 3,
    CourseYear = 2,
    Students = [student]
};

db.Groups.Add(group);

Student student1 = new()
{
    FirstName = "Qafariyye",
    LastName = "Qafaradze",
    Group = group

};

db.Students.Add(student1);

Faculty faculty = new() { FacultyName = "BackEnd programming" };

db.Faculties.Add(faculty);

db.Departments.Add(
    new Department()
    {
        DepartmentName = "Development",
        Teachers = [
            new Teacher()
            {
                FirstName = "Ridan",
                LastName = "Namazov",
                Email = "namazov@itstep.org",
                Salary = 25331116,
                Bonus = 1000000
            },
            new Teacher()
            {
                FirstName = "Nadir",
                LastName = "Zamanov",
                Email = "Zamanov@itstep.org",
                Salary = 20,
                Bonus = 1.5
            }
            ]
    }
    );

db.SaveChanges();