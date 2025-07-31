// Sql Injection
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");

var config = builder.Build();
string connectionString = config
                .GetConnectionString("MyJsonConnectionString")!;

#region SQL Injection
//using (SqlConnection conn = new(connectionString))
//{
//    conn.Open();
//    string id = Console.ReadLine()!;
//    SqlCommand command = new(@$"SELECT * FROM Authors WHERE Id = {id}", conn);

//    SqlDataReader reader = command.ExecuteReader();

//    do
//    {
//        while (reader.Read())
//        {
//            Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//        }
//    } while (reader.NextResult());

//}
#endregion


#region Parametrized Query
using (SqlConnection conn = new(connectionString))
{
    conn.Open();
    string id = Console.ReadLine()!;


    SqlCommand command = new(@$"SELECT * 
                                FROM Authors 
                                WHERE Id > @id AND FirstName NOT LIKE @firstName", conn);

    //SqlParameter parameter = new();
    //parameter.ParameterName = "@id";
    //parameter.SqlDbType = System.Data.SqlDbType.Int;
    //parameter.Value = id;

    //command.Parameters.Add(parameter);

    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
    command.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar).Value = Console.ReadLine()!;

    SqlDataReader reader = command.ExecuteReader();

    do
    {
        while (reader.Read())
        {
            Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
        }
    } while (reader.NextResult());

}
#endregion
