#region ADO
/*
ADO .NET - ActiveX Data Object for .NET
https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/
https://en.wikipedia.org/wiki/ADO.NET

MSSQL Server, Oracle, OLE DB, ODBC, ...

ADO Classes
    - DbConnection (SqlConnection, ...)
    - DbCommand
    - DbDataReader
    - DbDataAdapter

ADO Datatype for DB
    - DataTable
    - DataSet
    - ...

Connection modes
    - Connected Mode
    - Disconnected Mode

- DB First
- Code First
- Model First
 
*/
#endregion

#region Connection Strings
// https://www.connectionstrings.com/sqlconnection/

// Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
// Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;

// Server=myServerAddress;Database=myDataBase;Integrated Security=true;
// Server=myServerAddress;Database=myDataBase;Integrated Security=SSPI;

// Data Source=STHQ0124-01;User ID=admin;Password=********;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False
#endregion

using Microsoft.Data.SqlClient;

SqlConnection connection = default!;

string connectionString = @"Server=STHQ0124-01; 
                            Database=AdoTest;
                            User Id=admin;
                            Password=admin;
                            Trust Server Certificate=True;";


#region Database Connection
//connection = new SqlConnection(connectionString);

//string insertQuery = @"INSERT INTO Authors(FirstName, LastName)
//                        VALUES('Joseph', 'Albahari')";

////SqlCommand command = new(insertQuery, connection);

//SqlCommand command = new();
//command.Connection = connection;
//command.CommandText = insertQuery;

//try
//{
//    connection.Open();
//    command.ExecuteNonQuery();
//}
//finally
//{
//    if (connection is not null) connection.Close();
//}
#endregion

#region Database Connection with using
//SqlCommand command = new();

//using (connection = new(connectionString))
//{
//    connection.Open();
//    string firstName = Console.ReadLine()!;
//    string lastName = Console.ReadLine()!;

//    string insertQuery = @$"INSERT INTO Authors(FirstName, LastName)
//                        VALUES('{firstName}', '{lastName}')";
//    command.CommandText = insertQuery;
//    command.Connection = connection;

//    command.ExecuteNonQuery();

//}


#endregion
