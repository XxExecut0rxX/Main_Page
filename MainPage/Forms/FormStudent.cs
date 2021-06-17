using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainPage.Forms
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }


        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }

        private void tb_rbaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            
          
        }

        private void tb_rude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }
    }
}
