using ADO_NET_06._Loadings._Eager_Loading._Library;
using Microsoft.EntityFrameworkCore;

using LibraryContext db = new();

var students = db.Students
                        .Include(s => s.SCards)
                        .ThenInclude(sc => sc.Book)
                        .ThenInclude(b=> b.IdAuthorNavigation)
                        .ToList();

/*
SELECT *
FROM Students AS S
LEFT JOIN S_Cards AS SC ON S.Id = SC.Id_Student
LEFT JOIN Books AS B ON B.Id = SC.Id_Book
LEFT JOIN Authors AS A ON A.Id = B.Id_Author 
*/

foreach (var student in students)
{
    foreach (var sc in student.SCards)
    {
        if (sc.DateIn is null)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
            Console.WriteLine($"    {sc.Book.Name} -> {sc.Book.IdAuthorNavigation.FirstName} {sc.Book.IdAuthorNavigation.LastName}");
        }
        Console.WriteLine();
    }
}

