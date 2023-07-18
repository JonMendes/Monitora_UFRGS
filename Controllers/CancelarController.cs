using MonitoraUFRGS.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonitoraUFRGS.Controllers
{
    public class CancelarController()
    {
        private const string connectionString = "Server=localhost;Port=5432;Database=monitora_ufrgs;User Id=postgres;Password=r3c0v4l3;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        public void cancelarAula(int idA)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                connection.Open();

                command.CommandText = @"
                    DELETE FROM Aula WHERE idAula = @ID
                "
                ;

                command.Parameters.AddWithValue("ID", idA);

                command.ExecuteNonQuery();
            }
        }
    }
}
