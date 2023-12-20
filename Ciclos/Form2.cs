using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btnComeçarCiclo_Click(object sender, EventArgs e)
        {
            while (i < 5)
            {
                Lista.Items.Add(i);
                i++;
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
