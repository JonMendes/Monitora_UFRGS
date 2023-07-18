using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonitoraUFRGS.Models;
using Npgsql;

namespace MonitoraUFRGS.Controllers
{
    public class ConfirmarController{

        private const string connectionString = "Server=localhost;Port=5432;Database=monitora_ufrgs;User Id=postgres;Password=r3c0v4l3;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        public void confirmarAula(int idA)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                connection.Open();

                command.CommandText = @"
                 UPDATE Aula SET confirmado=TRUE WHERE idAula = @ID
                "
                ;

                command.Parameters.AddWithValue("ID", idA);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
