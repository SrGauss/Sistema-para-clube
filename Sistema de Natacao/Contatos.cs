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
    public partial class Contatos : Form
    {
        public Contatos()
        {
            InitializeComponent();
        }

        private void Contatos_Load(object sender, EventArgs e)
        {

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnExpandir.Visible = false;
            btnExpandir.Enabled = false;

            btnExpandir2.Visible = true;
            btnExpandir2.Enabled = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMinimizar.Visible = true;
        }

        private void btnExpandir2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnExpandir2.Visible = false;
            btnExpandir2.Enabled = false;

            btnExpandir.Visible = true;
            btnExpandir.Enabled = true;
        }
    }
}
