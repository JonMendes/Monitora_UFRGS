using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonitoraUFRGS.Models;
using Npgsql;

namespace MonitoraUFRGS.Controllers
{
    public class ConfirmarController()
    {

        private NpgsqlConnection connection;

        public ConfirmarController(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public void AtualizarTabelaAula(Aula a)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;
                command.CommandText = @"
                 UPDATE Aula SET confirmado=TRUE WHERE idAula = @ID
                "
                ;

                command.Parameters.AddWithValue("ID", a.idAula);

                command.ExecuteNonQuery();
            }
        }
    }
}
