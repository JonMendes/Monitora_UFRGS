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
                command.Parameters.AddWithValue("ID", a.idAula);
                command.Parameters.AddWithValue("Hora de início", a.horaInicio);
                command.Parameters.AddWithValue("Hora de término", a.horaFinal);
                command.Parameters.AddWithValue("Disciplina", a.disciplina);
                command.Parameters.AddWithValue("Confirmado", a.confirmado);
                command.Parameters.AddWithValue("Remoto", a.remoto);
                command.Parameters.AddWithValue("ID do Monitor", a.idMonitor);
                command.Parameters.AddWithValue("ID do Aluno", a.idAluno);
                

                command.ExecuteNonQuery();
            }
        }
    }
}


