using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraUFRGS.Models
{
    public class Aula
    {
        // Atributos
        [Key]
        public int idAula { get; set; }
        [Column("horaInicio")]
        public DateTime horaInicio { get; set; }
        [Column("horaFinal")]
        public DateTime horaFinal { get; set; }
        [Column("disciplina")]
        public string disciplina { get; set; }
        [Column("confirmado")]
        public bool confirmado { get; set; }
        [Column("remoto")]
        public bool remoto { get; set; }
        [ForeignKey("monitor")]
        public int idMonitor { get; set; }
        [ForeignKey("aluno")]
        public int idAluno { get; set; }

        // Relacionamentos de navegação
        public virtual Aluno aluno { get; set; }
        public virtual Monitor monitor { get; set; }

        // Construtor
        public Aula() { }

        // Metodos
        /// <summary>
        /// Atribui esta aula a um monitor
        /// </summary>
        public void atribuirMonitor()
        {

        }
    }
}
