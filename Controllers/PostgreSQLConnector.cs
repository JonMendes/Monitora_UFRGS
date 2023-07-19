using Npgsql;

public class PostgreSQLConnector
{
    private const string serverIP = "localhost";
    private const string port = "5432";
    private const string database = "monitora_ufrgs";
    private const string user_id = "postgres";
    private const string password = "r3c0v4l3";
    private const string connectionString = $"Server={serverIP};Port={port};Database={database};User Id={user_id};Password={password};";

    public static NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(connectionString);
    }
}
