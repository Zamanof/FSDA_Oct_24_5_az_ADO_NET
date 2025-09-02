// See https://aka.ms/new-console-template for more information

using Dapper;
using Microsoft.Data.SqlClient;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=True;Trust Server Certificate=True;");

//var sqlQuery = @"
//SELECT *
//FROM Authors AS A
//JOIN AuthorBook AS AB
//ON A.Id = AB.AuthorsId
//JOIN Books AS B
//ON B.Id = AB.BooksId";

//var authors = db.Query<Author, Book, Author>(sqlQuery,
//    (a, b) =>
//    {
//        a.Books.Add(b);
//        return a;
//    }
//    );

//foreach (var author in authors)
//{
//    Console.Write(author);
//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($" -> {book}");
//    }
//}