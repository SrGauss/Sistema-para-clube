using MySql.Data.MySqlClient;
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
    public partial class Historico : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=natacao");
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT `titulosConquistados`, `participacoes`, `maioresVencedores` FROM `historico`", conn);

                object result = command.ExecuteScalar();

                MySqlDataReader leitor = command.ExecuteReader();

                //Comunicação com banco de dados

                while (leitor.Read())
                {
                    lblTitulos.Text = leitor[0].ToString();
                    lblParticipacoes.Text = leitor[1].ToString();
                    lblVencedores.Text = leitor[2].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                lblVencedores.Text = ex.Message;
            }
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnExpandir.Visible = false;
            btnExpandir.Enabled = false;

            btnExpandir2.Visible = true;
            btnExpandir2.Enabled = true;
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

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMinimizar.Visible = true;
        }

        private void Historico_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Historico_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Historico_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
