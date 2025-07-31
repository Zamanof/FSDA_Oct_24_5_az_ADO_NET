﻿// Stored procedure execute

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");

var config = builder.Build();
string connectionString = config
                .GetConnectionString("MyJsonConnectionString")!;

#region Create Procedure
//using (SqlConnection conn = new(connectionString))
//{
//    conn.Open();

//    SqlCommand command = 
//        new(@"CREATE PROC GetBooksCount
//               @AuthorId int, @BooksCount int OUTPUT
//                AS
//                BEGIN
//                    SELECT @BooksCount = COUNT(*)
//                    FROM Books AS B JOIN Authors AS A ON A.Id = B.Id_Author
//                    WHERE A.Id = @AuthorId
//                END", conn);
//    command.ExecuteNonQuery();
//}
#endregion

#region Execute procedure
using (SqlConnection conn = new(connectionString))
{
    conn.Open();
    SqlCommand command = new("GetBooksCount", conn);
    command.CommandType = System.Data.CommandType.StoredProcedure;

    string id = Console.ReadLine()!;
    command.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int).Value = id;

    SqlParameter output = new("@BooksCount", System.Data.SqlDbType.Int);
    output.Direction = System.Data.ParameterDirection.Output;

    command.Parameters.Add(output);

    command.ExecuteNonQuery();

    Console.WriteLine(command.Parameters["@BooksCount"].Value);
}
#endregion