// Dapper ORM
using ADO_NET_08._Dapper_ORM;
using Microsoft.Data.SqlClient;


Console.WriteLine();
var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Authors;Integrated Security=True;Trust Server Certificate=True;";

IAuthorRepository repository = new AuthorRepository(new SqlConnection(), connectionString);

#region Add Data
//Author author = new() { FirstName = "Dan", LastName = "Brown" };
//repository.AddAuthor(author);
#endregion

#region Read Datas
//var authors = repository.GetAuthors().ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region Get Author By Id
//var author = repository.GetAuthorById(2);
//Console.WriteLine(author);
#endregion

#region Remove Data by Id
//repository.RemoveAuthorById(3);
#endregion

//repository.AddAuthors(
//[
//    new Author(){FirstName = "Filankes", LastName="Behmenkesov"},
//    new Author(){FirstName = "Salam", LastName="Qedirzade"},
//    new Author(){FirstName = "Saqol", LastName="Etirzade"}
//]);

//repository.RemoveAuthorsById([1, 3, 5, 7, 78]);

var author = repository.GetAuthorById(18);
author.FirstName = "Aqamirze";
repository.UpdateAuthor(author);