using MonitoraUFRGS.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoraUFRGS
{
    public partial class Confirmar : Form
    {
        private List<string> listaAulas;
        private ListarAulaMonitorController lac;
        private ConfirmarController confirmarc;
        private CancelarController cancelarc;

        public Confirmar()
        {
            InitializeComponent();

            lac = new();
            confirmarc = new();
            cancelarc = new();

            listaAulas = lac.listarAulaMonitor(00190200); // recebe lista do controller
            list_Aulas.DataSource = listaAulas; // atualiza a lista
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            // get aula selecionada
            var value = list_Aulas.SelectedItem;
            string aula = value.ToString();
            int index = aula.IndexOf(" ");
            if (index >= 0)
                aula = aula.Substring(0, index);

            confirmarc.confirmarAula(Int16.Parse(aula));

            listaAulas = lac.listarAulaMonitor(00190200); // recebe lista do controller
            list_Aulas.DataSource = listaAulas; // atualiza a lista
        }

        private void button_Recusar_Click(object sender, EventArgs e)
        {
            var value = list_Aulas.SelectedItem;
            string aula = value.ToString();
            int index = aula.IndexOf(" ");
            if (index >= 0)
                aula = aula.Substring(0, index);
                
            cancelarc.cancelarAula(Int16.Parse(aula));

            listaAulas = lac.listarAulaMonitor(00190200); // recebe lista do controller
            list_Aulas.DataSource = listaAulas; // atualiza a lista
        }
    }
}
