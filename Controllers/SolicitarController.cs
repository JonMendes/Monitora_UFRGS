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
    class SolicitarController()
    {
       
        private NpgsqlConnection connection;

        public SolicitarController(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public void CriarTabelaAula(Aula a)
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
                command.CommandText = @"
                INSERT INTO Aula (idAula, horaInicio, horaFinal, disciplina, confirmado, remoto, idMonitor, idAluno)
                VALUES (@ID, @Hora de início, @Hora de término, @Disciplina, @Confirmado, @Remoto, @ID do Monitor, @ID do Aluno)
            ";
                command.Parameters.AddWithValue("ID", a.getIdAula());
                command.Parameters.AddWithValue("Hora de início", a.getHoraInicio());
                command.Parameters.AddWithValue("Hora de término", a.getHoraFinal());
                command.Parameters.AddWithValue("Disciplina", a.getDisciplina());
                command.Parameters.AddWithValue("Confirmado", a.getConfirmado());
                command.Parameters.AddWithValue("Remoto", a.getRemoto());
                command.Parameters.AddWithValue("ID do Monitor", a.getIdMonitor());
                command.Parameters.AddWithValue("ID do Aluno", a.getIdAluno());
                

                command.ExecuteNonQuery();
            }

        }

}
}


