using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

public class PostgreSQLConnector
{
    private string connectionString = "Server=<PostgreSQL 15>;Port=<5432>;Database=<monitora_ufrgs>;User Id=<postgres>;Password=<r3c0v4l3>;";

    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(connectionString);
    }
}
