// Code First -> One To One

using ADO_NET_04._Code_First._One_to_One;
using Microsoft.EntityFrameworkCore;

using StudentContext db = new();

//Student student = new()
//{
//    FirstName = "Ne",
//    LastName = "Olsun",
//    BirthDay = new DateTime(2010, 5, 6)
//};
//StudentCard studentCard = new StudentCard()
//{
//    StartDate = new DateTime(2025, 8, 21),
//    EndDate = new DateTime(2029, 8, 21),
//    Student = student
//};

//db.StudentCards.Add(studentCard);

//db.SaveChanges();

var studentCard1 = db.StudentCards.Include(sc=> sc.Student).First();
Console.WriteLine(studentCard1);
Console.WriteLine(studentCard1.Student);

