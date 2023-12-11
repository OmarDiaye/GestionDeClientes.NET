namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
             GestionClientes gestionClientes = new GestionClientes();
             gestionClientes.ShowDialog();
        }
    }
}