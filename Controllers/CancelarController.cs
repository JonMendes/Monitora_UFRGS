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

        private NpgsqlConnection connection;

        //public CancelarController(NpgsqlConnection connection)
        //{
        //    this.connection = connection;
        //}

        public void ExcluirTabelaAula(Aula a)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;
                command.CommandText = @"
                    DELETE * FROM Aula WHERE idAula = @ID
                "
                ;

                command.Parameters.AddWithValue("ID", a.idAula);

                command.ExecuteNonQuery();
            }
        }
    }
}
