using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraUFRGS.Models
{
    public class Professor
    {
        [Key]
        private int _id;
        [Column("horaInicio")]
        private DateTime _horaInicio;

        public Professor() { }
    }
}
