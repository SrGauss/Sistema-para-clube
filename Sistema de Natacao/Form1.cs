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
    public partial class PaginaInicial : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

            System.Windows.Forms.Application.Exit();

            Application.Exit();

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

        private void btnDados_Click(object sender, EventArgs e)
        {
            DadosGerais dadosGerais = new DadosGerais();
            dadosGerais.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            historico.Show();
        }

        private void btnFinancia_Click(object sender, EventArgs e)
        {
            Financias financias = new Financias();
            financias.Show();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
        }

        private void PaginaInicial_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void PaginaInicial_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void PaginaInicial_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }




        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }




        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.Show();
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            TextRenderer.DrawText(
                e.Graphics,
                lbl.Text,
                lbl.Font,
                lbl.ClientRectangle,
                lbl.ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }
}
