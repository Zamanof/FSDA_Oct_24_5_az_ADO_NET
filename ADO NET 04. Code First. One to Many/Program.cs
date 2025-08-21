// Code First -> One To Many

using StudentContext db = new();

var group = new Group()
{
    Name = "FSDM_Oct_24_5_az",
    Students = new List<Student>()
    {
        new()
            {
                FirstName = "Ne",
                LastName = "Olsun",
                BirthDay = new DateTime(2010, 5, 6)
            },
        new()
            {
                FirstName = "O",
                LastName = "Olsun",
                BirthDay = new DateTime(2015, 5, 6)
            },
        new()
            {
                FirstName = "Azzar",
                LastName = "Olsun",
                BirthDay = new DateTime(2010, 5, 6)
            }
    }
};

db.Groups.Add(group);
db.SaveChanges();
