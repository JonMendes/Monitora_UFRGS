using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraUFRGS.Models
{
    public class Monitor
    {
        // Atributos
        [Key]
        private int _idAluno;
        [Column("nome")]
        private string _nome;
        [Column("curso")]
        private string _curso;
        [Column("disciplinaMonitoria")]
        private string _disciplinaMonitoria;
        [Column("nome")]
        private List<Tuple<DateTime, DateTime>> _horariosDisponiveis;
        [ForeignKey("orientador")]
        private int _idOrientador;

        public virtual Professor orientador { get; set; }

        // Construtor
        public Monitor() { }

        // Metodos
        /// <summary>
        /// Confirma uma aula que foi requisitada por um aluno.
        /// </summary>
        /// <param name="idAula">Identificador da aula</param>
        public void confirmarAula(int idAula)
        {

        }

        /// <summary>
        /// Cancela uma aula que foi requisitada por um aluno.
        /// </summary>
        /// <param name="idAula">Identificador da aula</param>
        public void cancelarAulaMonitor(int idAula)
        {

        }
    }
}
