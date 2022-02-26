using ClickHouse.Client.ADO;
using ClickHouse.Client.Utility;
using Dapper;
using System.Data.SqlClient;

try
{
    using var sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable("MSSQL_LOCAL"));
    sqlConnection.Open();
    var sqlVersion = await sqlConnection.ExecuteScalarAsync<string>("SELECT @@VERSION");
    Console.WriteLine(sqlVersion);

    using var clConnection = new ClickHouseConnection(Environment.GetEnvironmentVariable("CLICKHOUSE_LOCAL"));
    var clVersion = await clConnection.ExecuteScalarAsync("SELECT version()");
    Console.WriteLine(clVersion);
    Console.Read();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.Read();
}