
using Dapper;
using System.Data;

namespace ADO_NET_08._Dapper_ORM;

class AuthorRepository : IAuthorRepository
{
    private IDbConnection _db;

    public AuthorRepository(IDbConnection db, string connectionString)
    {
        _db = db;
        _db.ConnectionString = connectionString;
    }

    public Author AddAuthor(Author author)
    {
        var sqlQuery =
            @"INSERT INTO Author(FirstName, LastName)
              VALUES (@FirstName, @LastName)
              SELECT CAST(SCOPE_IDENTITY() AS int)";

        var id = _db.Query<int>(sqlQuery,
            new
            {
                @FirstName = author.FirstName,
                @LastName = author.LastName
            }).FirstOrDefault();

        author.Id = id;

        return author;
    }

    public void AddAuthors(IEnumerable<Author> authors)
    {
        authors.ToList().ForEach(a => AddAuthor(a));
        //foreach (var author in authors)
        //{
        //    AddAuthor(author);
        //}
    }

    public Author GetAuthorById(int id)
    {
        var sqlQuery = "SELECT * FROM Author WHERE Id=@Id";
        return _db.QueryFirstOrDefault<Author>(sqlQuery, new
        {
            @Id = id
        })!;
    }

    public IEnumerable<Author> GetAuthors()
    {
        var sqlQuery = @"SELECT * FROM Author";
        return _db.Query<Author>(sqlQuery);
    }

    public void RemoveAuthorById(int id)
    {
        var sqlQuery = "DELETE Author WHERE Id=@id";
        _db.Execute(sqlQuery, new { @id = id });
    }

    public void RemoveAuthorsById(int[] ids)
    {
        foreach (var id in ids)
        {
            RemoveAuthorById(id);
        }
    }

    public void UpdateAuthor(Author author)
    {
        var sqlQuery =
      @"UPDATE Author
          SET FirstName = @FirstName, LastName = @LastName
          WHERE Id = @Id";

        _db.Execute(sqlQuery, author);
    }
}
