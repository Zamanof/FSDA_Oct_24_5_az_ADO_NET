using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");

var config = builder.Build();
string connectionString = config
                .GetConnectionString("MyJsonConnectionString")!;

using (SqlConnection conn = new(connectionString))
{
    conn.Open();
    SqlCommand command =
        new(@"SELECT * 
              FROM Authors;
              SELECT Id, Name, Pages 
              FROM Books;", conn);

    SqlDataReader reader = command.ExecuteReader();

    do
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    } while (reader.NextResult());
}