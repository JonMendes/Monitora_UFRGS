using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoraUFRGS.View
{
    public partial class TelaAluno : Form
    {
        public TelaAluno()
        {
            InitializeComponent();
        }

        private void button_Solicitar_Click(object sender, EventArgs e)
        {
            new Solicitar().Show();
        }
    }
}
