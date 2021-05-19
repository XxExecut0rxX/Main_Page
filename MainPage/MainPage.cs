using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MainPage
{
    public partial class MainPage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public MainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_menu.Controls.Add(leftBorderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //structs
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(191, 74, 42);
            public static Color color2 = Color.FromArgb(128, 50, 28);
            public static Color color3 = Color.FromArgb(64, 25, 14);
            public static Color color4 = Color.FromArgb(250, 136, 58);
            public static Color color5 = Color.FromArgb(191, 74, 42);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Child Current form
                icon_currentChildForm.IconChar = currentBtn.IconChar;
                icon_currentChildForm.IconColor = color;
                lb_titleChildForm.ForeColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_desktop.Controls.Add(childForm);
            panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lb_titleChildForm.Text = childForm.Text;
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            OpenChildForm(new Forms.FormHome());
        }

        private void bt_student_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            OpenChildForm(new Forms.FormStudent());
        }

        private void bt_clipboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            OpenChildForm(new Forms.FormClipboard());
        }

        private void bt_signOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            OpenChildForm(new Forms.FormExit());
        }

        private void pic_home_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            //current child forms
            icon_currentChildForm.IconChar = IconChar.Home;
            icon_currentChildForm.IconColor = Color.MediumPurple;
            lb_titleChildForm.ForeColor = Color.MediumPurple;
            lb_titleChildForm.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //dragable form
        private void panel_titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
