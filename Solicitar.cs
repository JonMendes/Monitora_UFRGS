using MonitoraUFRGS.Controller;
using System.Security.Cryptography.X509Certificates;

namespace MonitoraUFRGS
{
    public partial class Solicitar : Form
    {
        public Solicitar()
        {
            InitializeComponent();
        }

        private void button_Solicitar_Click(object sender, EventArgs e)
        {
            string disciplina = textBox_Disciplina.Text;
            DateTime data = date_Data.Value;
            DateTime hora = date_Hora.Value.ToUniversalTime();
            bool remota = checkBox_Remota.Checked;

            SolicitarController sc = new SolicitarController(disciplina, data, hora, remota);
        }

        private void textBox_Disciplina_TextChanged(object sender, EventArgs e)
        {

        }



    }
}