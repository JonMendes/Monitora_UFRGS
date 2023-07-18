namespace MonitoraUFRGS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button_FormSolicitar_Click(object sender, EventArgs e)
        {
            Solicitar formSolicitar = new();
            formSolicitar.ShowDialog();
        }

        private void button_FormConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar formConfirmar = new();
            formConfirmar.ShowDialog();
        }
    }
}