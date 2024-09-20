using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Login : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public Login()
        {
            InitializeComponent();
        }


        public String Valor
        {
            get { return txbUser.Text; }
            set { txbUser.Text = value; }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=natacao");

                conn.Open();

                MySqlCommand command = new MySqlCommand("SELECT `usuario` FROM `login` WHERE `usuario` = @Nome AND `senha` = @Senha", conn);

                command.Parameters.AddWithValue("@Nome", txbUser.Text);

                command.Parameters.AddWithValue("@Senha", txbSenha.Text);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.Show();

                    this.Hide();
                }
                else
                {
                    lblVerifica.Text = "Usuário ou senha incorretos.";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                lblVerifica.Text = ex.Message;
            }
            finally
            {
                txbUser.Text = "";
                txbSenha.Text = "";

                
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblVerifica.Text = "";
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

        private void label3_Paint(object sender, PaintEventArgs e)
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

        private void lblVerifica_Paint(object sender, PaintEventArgs e)
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

        private void label4_Paint(object sender, PaintEventArgs e)
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
