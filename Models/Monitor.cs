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
        public int idAluno { get; set; }
        [Column("nome")]
        public string nome { get; set; }
        [Column("curso")]
        public string curso { get; set; }
        [Column("disciplinaMonitoria")]
        public string disciplinaMonitoria { get; set; }
        [Column("nome")]
        public List<Tuple<DateTime, DateTime>> horariosDisponiveis { get; set; }
        [ForeignKey("orientador")]
        public int idOrientador { get; set; }

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
