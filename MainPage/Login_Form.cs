using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        //user and password registered

        private string userAuth = "admin";
        private string passAuth = "password123";

        //Stiling and design

        private void pb_login_MouseLeave(object sender, EventArgs e)
        {
            pb_login.BackgroundImage = Properties.Resources.btn2;
        }
        private void pb_login_MouseMove(object sender, MouseEventArgs e)
        {
            pb_login.BackgroundImage = Properties.Resources.btn1;
        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void tb_user_Click(object sender, EventArgs e)
        {
            tb_user.Clear();
            tb_user.ForeColor = Color.Black;
        }
        private void tb_pass_Click(object sender, EventArgs e)
        {
            tb_pass.Clear();
            tb_pass.UseSystemPasswordChar = true;
            tb_pass.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void Login_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Login_Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Authentication
        private void pb_login_Click(object sender, EventArgs e)
        {
            if(tb_user.Text == userAuth && tb_pass.Text == passAuth)
            {
                MainPage loadMp = new MainPage();
                loadMp.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario incorrecto, vuelva a intentarlo");
                tb_user.Text = "";
                tb_pass.Text = "";
            }
        }
    }
}
