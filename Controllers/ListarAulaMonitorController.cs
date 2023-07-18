﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonitoraUFRGS.Models;
using Npgsql;

namespace MonitoraUFRGS.Controllers
{
    public class ListarAulaMonitorController
    {
        private const string connectionString = "Server=localhost;Port=5432;Database=monitora_ufrgs;User Id=postgres;Password=r3c0v4l3;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        private List<string> aulas = new();

        public List<string> listarAulaMonitor(int nroMonitor)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                connection.Open();

                command.CommandText = @"
                 SELECT * FROM Aula WHERE idMonitor = IdMonitor
                "
                ;

                NpgsqlCommand cmd = new NpgsqlCommand(command.CommandText, connection);
                
                command.Parameters.AddWithValue("IdMonitor", nroMonitor);

                NpgsqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    aulas.Add(converteAula(reader));
                }
                
                connection.Close();
                return aulas;
            }
        }

        private static string converteAula(NpgsqlDataReader reader)
        {
            string aula = null;
            int? id = reader["idAula"] as int?;
            int? idA = reader["idAluno"] as int?;
            bool? remoto = reader["remoto"] as bool?;
            bool? confirmado = reader["confirmado"] as bool?;

            if(confirmado == false)
                aula = "" + id + " - Aluno " + idA + " Remoto: " + remoto;

            return aula;
        }
    }
}
