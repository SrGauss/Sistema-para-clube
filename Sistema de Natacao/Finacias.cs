using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Natacao
{
    public partial class Financias : Form
    {
        public Financias()
        {
            InitializeComponent();
        }

        private void Financias_Load(object sender, EventArgs e)
        {

        }

        private void btnExpandir2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMinimizar.Visible = true;
        }

        private void btnExpandir_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnExpandir.Visible = false;
            btnExpandir.Enabled = false;

            btnExpandir2.Visible = true;
            btnExpandir2.Enabled = true;
        }
    }
}
