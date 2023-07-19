using Npgsql;

namespace MonitoraUFRGS.Controllers
{
    public class CancelarController()
    {
        private NpgsqlConnection connection = PostgreSQLConnector.GetConnection();

        public void cancelarAula(int idA)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                connection.Open();

                command.CommandText = @"DELETE FROM Aula WHERE idAula = @ID";

                command.Parameters.AddWithValue("ID", idA);

                command.ExecuteNonQuery();
            }
        }
    }
}
