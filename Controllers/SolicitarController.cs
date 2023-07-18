using MonitoraUFRGS;
using MonitoraUFRGS.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonitoraUFRGS.Controllers
{
    public class SolicitarController
    {
        //PostgreSQLConnector connector = new();
       
        private const string connectionString = "Server=localhost;Port=5432;Database=monitora_ufrgs;User Id=postgres;Password=r3c0v4l3;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        //connection = connector.GetConnection();

        // public SolicitarController()
        // {
        //    this.connection = connector.GetConnection();
        // }

        public void CriarTabelaAula()
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Aula (
                    idAula INTEGER PRIMARY KEY,
                    horaInicio TIMESTAMP,
                    horaFinal TIMESTAMP,
                    disciplina VARCHAR(255),
                    confirmado BOOLEAN,
                    remoto BOOLEAN,
                    idMonitor INTEGER,
                    idAluno INTEGER,
                    FOREIGN KEY (idMonitor) REFERENCES monitor (idAluno),
                    FOREIGN KEY (idAluno) REFERENCES aluno (idAluno)
                )
                ";
                command.ExecuteNonQuery();
            }
        }

        public void InserirAula(Aula a)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                connection.Open();

                command.CommandText = @"
                INSERT INTO Aula (idAula, horaInicio, horaFinal, disciplina, confirmado, remoto, idMonitor, idAluno)
                VALUES (@ID, @Horadeinicio, @Horadetermino, @Disciplina, @Confirmado, @Remoto, @IDdoMonitor, @IDdoAluno)
                ";
                command.Parameters.AddWithValue("ID", a.idAula);
                command.Parameters.AddWithValue("Horadeinicio", a.horaInicio);
                command.Parameters.AddWithValue("Horadetermino", a.horaFinal);
                command.Parameters.AddWithValue("Disciplina", a.disciplina);
                command.Parameters.AddWithValue("Confirmado", a.confirmado);
                command.Parameters.AddWithValue("Remoto", a.remoto);
                command.Parameters.AddWithValue("IDdoMonitor", a.idMonitor);
                command.Parameters.AddWithValue("IDdoAluno", a.idAluno);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}


