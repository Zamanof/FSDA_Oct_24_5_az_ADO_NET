using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

string connectionString = @"Server=(localdb)\MSSQLLocalDB; 
                            Database=AdoTest;
                            Integrated Security=SSPI;
                            Trust Server Certificate=True;";

SqlDataReader reader = null!;
SqlCommand cmd = null!;

#region Read Data
//using (var conn = new SqlConnection(connectionString))
//{
//    cmd = new SqlCommand(@"SELECT * FROM Authors", conn);

//    conn.Open();

//    reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//    }

//}
#endregion

#region Read Data indexer
//using (var conn = new SqlConnection(connectionString))
//{
//    cmd = new SqlCommand(@"SELECT * FROM Authors", conn);

//    conn.Open();

//    reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//    }
//}
#endregion


using (var conn = new SqlConnection(connectionString))
{
    cmd = new SqlCommand(@"SELECT * FROM Authors", conn);

    conn.Open();

    reader = cmd.ExecuteReader();
    //Console.WriteLine(reader.FieldCount);
    //Console.WriteLine(reader.GetName(1));

    bool line = true;

    while (reader.Read())
    {
        if (line)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader.GetName(i)}\t\t");
            }
            Console.WriteLine();
            line = false;
        }
        for (int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write($"{reader[i]}\t\t");
        }
        Console.WriteLine();

    }
}