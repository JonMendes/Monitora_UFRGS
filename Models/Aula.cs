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
        private int _idAula;
        [Column("horaInicio")]
        private DateTime _horaInicio;
        [Column("horaFinal")]
        private DateTime _horaFinal;
        [Column("disciplina")]
        private string _disciplina;
        [Column("confirmado")]
        private bool _confirmado;
        [Column("remoto")]
        private bool _remoto;
        [ForeignKey("monitor")]
        private int _idMonitor;
        [ForeignKey("aluno")]
        private int _idAluno;

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
