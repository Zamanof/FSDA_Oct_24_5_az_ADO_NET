// Read releational datas

// + Eager loading
// - Explicit loading
// - Lazy loading

using Microsoft.EntityFrameworkCore;

using ApplicationContext db = new();
#region Add Data
//List<Student> programmingStudents = new List<Student>
//{
//    new Student { FirstName = "Ilgar", LastName = "Aliyev", Age = 21 },
//    new Student { FirstName = "Nazrin", LastName = "Huseynova", Age = 19 },
//    new Student { FirstName = "Elchin", LastName = "Mammadov", Age = 22 },
//    new Student { FirstName = "Naila", LastName = "Ismayilova", Age = 20 },
//    new Student { FirstName = "Kamila", LastName = "Tagiyeva", Age = 18 },
//    new Student { FirstName = "Tofig", LastName = "Rahimov", Age = 23 },
//    new Student { FirstName = "Lale", LastName = "Karimova", Age = 19 },
//    new Student { FirstName = "Rashid", LastName = "Suleymanov", Age = 20 },
//    new Student { FirstName = "Sevinc", LastName = "Aliyeva", Age = 21 },
//    new Student {  FirstName = "Adnan", LastName = "Qasimov", Age = 22 },
//    new Student {  FirstName = "Aysel", LastName = "Mammadova", Age = 20 },
//    new Student {  FirstName = "Rauf", LastName = "Isgandarov", Age = 23 },
//    new Student {  FirstName = "Sabina", LastName = "Tagiyeva", Age = 19 },
//    new Student {  FirstName = "Murad", LastName = "Karimov", Age = 20 },
//    new Student {  FirstName = "Zahra", LastName = "Rahimova", Age = 21 },
//    new Student {  FirstName = "Emin", LastName = "Aliyev", Age = 18 },
//    new Student {  FirstName = "Aytac", LastName = "Suleymanova", Age = 19 },
//    new Student {  FirstName = "Cavid", LastName = "Huseynov", Age = 20 },
//    new Student {  FirstName = "Gulshan", LastName = "Mammadova", Age = 22 },
//    new Student {  FirstName = "Nihad", LastName = "Quliyev", Age = 23 },
//    new Student {  FirstName = "Samira", LastName = "Tagiyeva", Age = 20 },
//    new Student {  FirstName = "Fuad", LastName = "Aliyev", Age = 21 },
//    new Student {  FirstName = "Aygun", LastName = "Ismayilova", Age = 19 },
//    new Student {  FirstName = "Ramil", LastName = "Karimov", Age = 22 },
//    new Student {  FirstName = "Nigar", LastName = "Rahimova", Age = 20 }
//};

//List<Student> designStudents = new List<Student>
//{
//    new Student { FirstName = "Rashad", LastName = "Aliyev", Age = 20 },
//    new Student { FirstName = "Sevda", LastName = "Huseynova", Age = 19 },
//    new Student { FirstName = "Anar", LastName = "Mammadov", Age = 22 },
//    new Student { FirstName = "Ulker", LastName = "Ismayilova", Age = 18 },
//    new Student { FirstName = "Vusal", LastName = "Tagiyev", Age = 21 },
//    new Student { FirstName = "Gulnar", LastName = "Rahimova", Age = 20 },
//    new Student { FirstName = "Samira", LastName = "Karimova", Age = 19 },
//    new Student { FirstName = "Adil", LastName = "Suleymanov", Age = 23 },
//    new Student { FirstName = "Jale", LastName = "Aliyeva", Age = 20 },
//    new Student { FirstName = "Ramin", LastName = "Qasimov", Age = 21 },
//    new Student { FirstName = "Aydan", LastName = "Mammadova", Age = 18 },
//    new Student { FirstName = "Eldar", LastName = "Isgandarov", Age = 22 },
//    new Student { FirstName = "Aynur", LastName = "Tagiyeva", Age = 19 },
//    new Student { FirstName = "Zaur", LastName = "Karimov", Age = 20 },
//    new Student { FirstName = "Leman", LastName = "Rahimova", Age = 21 },
//    new Student { FirstName = "Ferhad", LastName = "Aliyev", Age = 22 },
//    new Student { FirstName = "Maya", LastName = "Suleymanova", Age = 19 },
//    new Student { FirstName = "Orxan", LastName = "Huseynov", Age = 20 },
//    new Student { FirstName = "Gunel", LastName = "Mammadova", Age = 18 },
//    new Student { FirstName = "Arif", LastName = "Quliyev", Age = 23 }
//};

//List<Student> cyberSecurityStudents = new List<Student>
//{
//    new Student { FirstName = "Ilgar", LastName = "Aliyev", Age = 21 },
//    new Student { FirstName = "Nazrin", LastName = "Huseynova", Age = 19 },
//    new Student { FirstName = "Elchin", LastName = "Mammadov", Age = 22 },
//    new Student { FirstName = "Naila", LastName = "Ismayilova", Age = 20 },
//    new Student { FirstName = "Kamila", LastName = "Tagiyeva", Age = 18 },
//    new Student { FirstName = "Tofig", LastName = "Rahimov", Age = 23 },
//    new Student { FirstName = "Lale", LastName = "Karimova", Age = 19 },
//    new Student { FirstName = "Rashid", LastName = "Suleymanov", Age = 20 },
//    new Student { FirstName = "Sevinc", LastName = "Aliyeva", Age = 21 },
//    new Student { FirstName = "Adnan", LastName = "Qasimov", Age = 22 },
//    new Student { FirstName = "Aysel", LastName = "Mammadova", Age = 20 },
//    new Student { FirstName = "Rauf", LastName = "Isgandarov", Age = 23 },
//    new Student { FirstName = "Sabina", LastName = "Tagiyeva", Age = 19 },
//    new Student { FirstName = "Murad", LastName = "Karimov", Age = 20 },
//    new Student { FirstName = "Zahra", LastName = "Rahimova", Age = 21 },
//    new Student { FirstName = "Emin", LastName = "Aliyev", Age = 18 },
//    new Student { FirstName = "Aytac", LastName = "Suleymanova", Age = 19 },
//    new Student { FirstName = "Cavid", LastName = "Huseynov", Age = 20 },
//    new Student { FirstName = "Gulshan", LastName = "Mammadova", Age = 22 },
//    new Student { FirstName = "Nihad", LastName = "Quliyev", Age = 23 },
//    new Student { FirstName = "Samira", LastName = "Tagiyeva", Age = 20 },
//    new Student { FirstName = "Fuad", LastName = "Aliyev", Age = 21 },
//    new Student { FirstName = "Aygun", LastName = "Ismayilova", Age = 19 },
//    new Student { FirstName = "Ramil", LastName = "Karimov", Age = 22 },
//    new Student { FirstName = "Nigar", LastName = "Rahimova", Age = 20 }
//};

//db.Groups.AddRange(
//    new Group() { GroupName = "Development Group", Students = programmingStudents },
//    new Group() { GroupName = "Design Group", Students = designStudents },
//    new Group() { GroupName = "Cyber Security Group", Students = cyberSecurityStudents }
//);

//db.SaveChanges();
#endregion


#region Eager loading. Include(), ThenInclude()
//var groups = db.Groups.Include(g => g.Students).ToList();
///*
//    SELECT *
//    FROM Groups AS G
//    JOIN Students AS S
//    ON S.GroupId = G.Id

// */


//foreach (var group in groups)
//{
//    Console.WriteLine(group);
//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"    {student}");
//    }
//    Console.WriteLine();
//}


//var students = db.Students.Include(s=> s.Group).ToList();

//students.ForEach(s => { 
//    Console.WriteLine($"{s} -> {s.Group}"); 
//});


#endregion

