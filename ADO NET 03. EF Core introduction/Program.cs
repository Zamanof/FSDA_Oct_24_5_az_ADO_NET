using ADO_NET_03._EF_Core_introduction;
// EF Core

// Database First
// Code First
// Model First

#region Add Data
//using (StudentContext db = new())
//{
//    Student student = new()
//    {
//        FirstName = "Ferqiyoxdu",
//        LastName = "Nebilimli",
//        Age = 35,
//        Gender = "male",
//        Group = "A13"
//    };

//    db.Students.Add(student);
//    db.SaveChanges();
//}
#endregion

#region Add Datas
//using (var db = new StudentContext())
//{
//    List<Student> students = new List<Student>
//    {
//        new()
//            {
//                FirstName = "Ferqiyoxdu",
//                LastName = "Nebilimli",
//                Age = 35,
//                Gender = "male",
//                Group = "A13"
//            },
//        new()
//            {
//                FirstName = "Ferqiyoxdiyye",
//                LastName = "Nebilimli",
//                Age = 18,
//                Gender = "female",
//                Group = "A13"
//            },
//        new()
//            {
//                FirstName = "Gozel",
//                LastName = "Gozelli",
//                Age = 25,
//                Gender = "male",
//                Group = "A8"
//            },
//        new()
//            {
//                FirstName = "Yuzel",
//                LastName = "Yuzelli",
//                Age = 150,
//                Gender = "male",
//                Group = "A13"
//            }
//    };

//    //foreach (var st in students)
//    //{
//    //    db.Students.Add(st);
//    //}

//    db.Students.AddRange(students);

//    db.SaveChanges();
//}

#endregion

#region Read Data

//using (StudentContext db = new StudentContext())
//{
//    var student = db.Students.FirstOrDefault(s => s.Id == 9);
//    if (student is not null) Console.WriteLine(student);
//    else Console.WriteLine("Student not found");
//}

#endregion

#region Read Datas

//using (StudentContext db = new StudentContext())
//{
//    //List<Student> students = new();
//    //foreach (var st in db.Students)
//    //{
//    //    students.Add(st);
//    //}

//    var students = db.Students.ToList();
//    students.ForEach(Console.WriteLine);
//}

#endregion

#region Update data
//using StudentContext db = new();
//var student = db.Students.FirstOrDefault(s=> s.Id == 27);
//student!.FirstName = "Salam";
//student.LastName = "Salamzade";

//db.Students.Update(student);
//db.SaveChanges();
#endregion

#region Delete datas
using StudentContext db = new();

//db.Students.Remove(db.Students.First());

var deleteStudents = db.Students.Where(s => s.Id <= 8);
db.Students.RemoveRange(deleteStudents);

db.SaveChanges();


#endregion