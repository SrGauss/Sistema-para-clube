using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Natacao
{
    public partial class DadosGerais : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public DadosGerais()
        {
            InitializeComponent();
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

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DadosGerais_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void DadosGerais_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void DadosGerais_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnExpandir_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnExpandir.Visible = false;
            btnExpandir.Enabled = false;

            btnExpandir2.Visible = true;
            btnExpandir2.Enabled = true;
        }

        private void DadosGerais_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=natacao");
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT `nomeCompleto`, `nomeAbreviado`, `dataFundacao`, `coresOficiais`, `patrocinadores` FROM `dadosgerais`", conn);

                object result = command.ExecuteScalar();

                MySqlDataReader leitor = command.ExecuteReader();

                //Comunicação com banco de dados

                while (leitor.Read())
                {
                    lblNomeCompleto.Text = leitor[0].ToString();
                    lblNomeAbreviado.Text = leitor[1].ToString();
                    lblData.Text = leitor[2].ToString();
                    lblCores.Text = leitor[3].ToString();
                    lblPatroci.Text = leitor[4].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                lblNomeAbreviado.Text = ex.Message;
            }
        }

        //Aqui pra baixo é só para não mudar a cor da fonte

        private void lblNomeCompleto_Paint(object sender, PaintEventArgs e)
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

        private void lblData_Paint(object sender, PaintEventArgs e)
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

        private void lblCor_Paint(object sender, PaintEventArgs e)
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

        private void label1_Paint(object sender, PaintEventArgs e)
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
