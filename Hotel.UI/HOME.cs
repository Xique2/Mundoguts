namespace Hotel.UI
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            cliente.Show();
            this.Hide();
        }

        private void BtnHospedagem_Click(object sender, EventArgs e)
        {

        }
    }
}
