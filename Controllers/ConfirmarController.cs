using Npgsql;

namespace MonitoraUFRGS.Controllers
{
    public class ConfirmarController
    {
        private NpgsqlConnection connection = PostgreSQLConnector.GetConnection();

        public void confirmarAula(int idA)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                connection.Open();

                command.CommandText = @"
                 UPDATE Aula SET confirmado=TRUE WHERE idAula = @ID
                ";

                command.Parameters.AddWithValue("ID", idA);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
