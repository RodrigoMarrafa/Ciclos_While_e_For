namespace Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComeçarCiclo_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            for (int a = 1; a <= 100; a = a + 2)
            {
                Lista.Items.Add(a);
            }
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}