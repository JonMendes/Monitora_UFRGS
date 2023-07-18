using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraUFRGS.Models
{

    [Table("aluno")]
    public class Aluno
    {
        // Atributos
        [Key]
        private int _idAluno;
        [Column("nome")]
        private string _nome;
        [Column("curso")]
        private string _curso;
        [Column("disciplinasMatriculadas")]
        private List<string> _disciplinasMatriculadas;

        // Construtor
        public Aluno() { }

        // Metodos
        /// <summary>
        /// Faz uma requisição para marcar uma aula de monitoria.
        /// </summary>
        /// <param name="horario">Horário da aula</param>
        /// <param name="disciplina">Disciplina desejada</param>
        /// <param name="remoto">Aula remota (true) ou presencial (false)</param>
        public void requisitarAula(DateTime horario, string disciplina, bool remoto)
        {

        }

        /// <summary>
        /// Cancela uma aula que foi confirmada ou não.
        /// </summary>
        /// <param name="idAula">Identificador da aula</param>
        public void cancelarAulaAluno(int idAula)
        {

        }
    }
}
