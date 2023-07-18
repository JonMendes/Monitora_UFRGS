using MonitoraUFRGS.Controllers;
using MonitoraUFRGS.Models;
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
            DateTime horaInicio = date_Data.Value;
            DateTime horaFinal = horaInicio.AddMinutes(30);
            bool remota = checkBox_Remota.Checked;

            Aula a = new Aula();
            Random r = new Random();

            a.disciplina = disciplina;
            a.horaInicio = horaInicio;
            a.horaFinal = horaFinal;
            a.remoto = remota;
            a.idAluno = 00290195;
            a.idMonitor = 00190200;
            //a.idAula não precisa pq é autoincrement

            SolicitarController sc = new SolicitarController();

            //sc.CriarTabelaAula();
            sc.InserirAula(a);

        }

        private void textBox_Disciplina_TextChanged(object sender, EventArgs e)
        {

        }



    }
}