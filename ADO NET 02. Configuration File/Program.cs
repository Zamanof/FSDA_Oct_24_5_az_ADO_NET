// Configuration file



// connection string in file(Hard Code) - not secure
//string connectionString = @"Server=(localdb)\MSSQLLocalDB; 
//                            Database=Library;
//                            Integrated Security=SSPI;
//                            Trust Server Certificate=True;";


using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");

var config = builder.Build();
string connectionString = config
                .GetConnectionString("MyJsonConnectionString")!;

List<Authors> authors = new();
using(SqlConnection conn = new(connectionString))
{
    conn.Open();
    SqlCommand command = new("SELECT * FROM Authors", conn);

    SqlDataReader reader = command.ExecuteReader();

    while (reader.Read())
    {
        authors.Add(new Authors
        {
            Id = (int)reader[0],
            FirstName = reader[1].ToString()!,
            LastName = reader[2].ToString()!
        });
    }
}

authors.ForEach(Console.WriteLine);





