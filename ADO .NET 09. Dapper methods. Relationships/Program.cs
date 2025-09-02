using Dapper;
using Microsoft.Data.SqlClient;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;Trust Server Certificate=True;");

#region Scalar Valued Queue -  ExecuteScalar()
//var result = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Books");
//Console.WriteLine(result);

//Console.WriteLine(db.ExecuteScalar<float>("SELECT AVG(Pages) FROM Books"));
#endregion

#region Querying a Single Row - QueryFirst,QueryFirstOrDefault,QuerySingle,QuerySingleOrDefault 
//var book = db.QueryFirstOrDefault<Book>(@"
//SELECT *
//FROM Books
//WHERE Name Like @Name
//", new { @Name = "%Visual%"});

//if (book is not null) Console.WriteLine(book);
//else Console.WriteLine("Book not found");

/*
SELECT TOP(1) *
FROM Books
WHERE Name Like '%Visual%'
 
 */


//var book1 = db.QuerySingleOrDefault<Book>(@"
//SELECT *
//FROM Books
//WHERE Name Like @Name
//", new { @Name = "%HTML%" });

//if (book1 is not null) Console.WriteLine(book1);
//else Console.WriteLine("Book not found");
#endregion


#region Querying Multiple Rows
//var books = db.Query<Book>("SELECT * FROM Books").ToList();
//books.ForEach(Console.WriteLine);
#endregion

#region Querying Multiple Results  - QueryMultiple, Read, ReadFirst, ReadFirstOrDefault, ReadSingle, ReadSingleOrDefault 

//var sqlQuery = @"
//SELECT * FROM Authors WHERE FirstName = @FirstName;
//SELECT * FROM Books   WHERE Id > @Id;";

//var results = db.QueryMultiple(sqlQuery, new { @FirstName = "Mark", @Id = 5 });

//var authors = results.Read<Author>().ToList();
//var books = results.Read<Book>().ToList();


//authors.ForEach(Console.WriteLine);
//Console.WriteLine();
//books.ForEach(Console.WriteLine);

//var results1 = db.QueryMultiple(sqlQuery, new { @FirstName = "Mark", @Id = 5 });

//var author = results1.ReadFirstOrDefault<Author>();
//var book = results1.ReadFirstOrDefault<Book>();

//Console.WriteLine(author);
//Console.WriteLine(book);


#endregion

#region Querying Specific Columns
//var sqlQuery = "SELECT Id, FirstName FROM Authors";

//var authors = db.Query<Author>(sqlQuery).ToList();

//authors.ForEach(Console.WriteLine);

#endregion

#region One To Many
//var sqlQuery = @"
//SELECT *
//FROM Students AS S
//JOIN Groups AS G
//ON G.Id = S.Id_Group
//";

//var students = db.Query<Student, Group, Student>(sqlQuery,
//    (s, g)=>
//    {
//        s.Group = g;
//        return s;
//    }
//    ).ToList();

//students.ForEach(Console.WriteLine);

//var groupDict = new Dictionary<int, Group>();
//var groups = db.Query<Student, Group, Group>(sqlQuery,
//    (s, g) =>
//    {
//        if (!groupDict.TryGetValue(g.Id, out var exsitingGroup))
//        {
//            exsitingGroup = g;
//            exsitingGroup.Students = new List<Student>();
//            groupDict.Add(g.Id, exsitingGroup);
//        }
//        exsitingGroup.Students.Add(s);
//        return exsitingGroup;
//    }
//    ).Distinct().ToList();

//foreach (var group in groups)
//{
//    Console.WriteLine(group);

//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"    {student.FirstName} {student.LastName}");
//    }
//}

#endregion