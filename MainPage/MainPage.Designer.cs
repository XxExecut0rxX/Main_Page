
namespace MainPage
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.bt_signOut = new FontAwesome.Sharp.IconButton();
            this.bt_clipboard = new FontAwesome.Sharp.IconButton();
            this.bt_student = new FontAwesome.Sharp.IconButton();
            this.bt_home = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pic_home = new FontAwesome.Sharp.IconPictureBox();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.btn_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.btn_maximize = new FontAwesome.Sharp.IconPictureBox();
            this.btn_close = new FontAwesome.Sharp.IconPictureBox();
            this.icon_currentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lb_titleChildForm = new System.Windows.Forms.Label();
            this.panel_shadow = new System.Windows.Forms.Panel();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            this.panel_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_currentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_menu.Controls.Add(this.bt_signOut);
            this.panel_menu.Controls.Add(this.bt_clipboard);
            this.panel_menu.Controls.Add(this.bt_student);
            this.panel_menu.Controls.Add(this.bt_home);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(220, 643);
            this.panel_menu.TabIndex = 0;
            // 
            // bt_signOut
            // 
            this.bt_signOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_signOut.FlatAppearance.BorderSize = 0;
            this.bt_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_signOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_signOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.bt_signOut.IconColor = System.Drawing.Color.Gainsboro;
            this.bt_signOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_signOut.Location = new System.Drawing.Point(0, 320);
            this.bt_signOut.Name = "bt_signOut";
            this.bt_signOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_signOut.Size = new System.Drawing.Size(220, 60);
            this.bt_signOut.TabIndex = 4;
            this.bt_signOut.Text = "Cerrar Sesion";
            this.bt_signOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_signOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_signOut.UseVisualStyleBackColor = true;
            this.bt_signOut.Click += new System.EventHandler(this.bt_signOut_Click);
            // 
            // bt_clipboard
            // 
            this.bt_clipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_clipboard.FlatAppearance.BorderSize = 0;
            this.bt_clipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clipboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_clipboard.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.bt_clipboard.IconColor = System.Drawing.Color.Gainsboro;
            this.bt_clipboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_clipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clipboard.Location = new System.Drawing.Point(0, 260);
            this.bt_clipboard.Name = "bt_clipboard";
            this.bt_clipboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_clipboard.Size = new System.Drawing.Size(220, 60);
            this.bt_clipboard.TabIndex = 3;
            this.bt_clipboard.Text = "Actualizar";
            this.bt_clipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_clipboard.UseVisualStyleBackColor = true;
            this.bt_clipboard.Click += new System.EventHandler(this.bt_clipboard_Click);
            // 
            // bt_student
            // 
            this.bt_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_student.FlatAppearance.BorderSize = 0;
            this.bt_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_student.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_student.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.bt_student.IconColor = System.Drawing.Color.Gainsboro;
            this.bt_student.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_student.Location = new System.Drawing.Point(0, 200);
            this.bt_student.Name = "bt_student";
            this.bt_student.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_student.Size = new System.Drawing.Size(220, 60);
            this.bt_student.TabIndex = 2;
            this.bt_student.Text = "Estudiante";
            this.bt_student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_student.UseVisualStyleBackColor = true;
            this.bt_student.Click += new System.EventHandler(this.bt_student_Click);
            // 
            // bt_home
            // 
            this.bt_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.bt_home.IconColor = System.Drawing.Color.Gainsboro;
            this.bt_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_home.Location = new System.Drawing.Point(0, 140);
            this.bt_home.Name = "bt_home";
            this.bt_home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_home.Size = new System.Drawing.Size(220, 60);
            this.bt_home.TabIndex = 1;
            this.bt_home.Text = "Home";
            this.bt_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pic_home);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(220, 140);
            this.panel_logo.TabIndex = 0;
            // 
            // pic_home
            // 
            this.pic_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_home.ForeColor = System.Drawing.Color.Coral;
            this.pic_home.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.pic_home.IconColor = System.Drawing.Color.Coral;
            this.pic_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pic_home.IconSize = 105;
            this.pic_home.Location = new System.Drawing.Point(59, 29);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(105, 105);
            this.pic_home.TabIndex = 0;
            this.pic_home.TabStop = false;
            this.pic_home.Click += new System.EventHandler(this.pic_home_Click);
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_titleBar.Controls.Add(this.btn_minimize);
            this.panel_titleBar.Controls.Add(this.btn_maximize);
            this.panel_titleBar.Controls.Add(this.btn_close);
            this.panel_titleBar.Controls.Add(this.icon_currentChildForm);
            this.panel_titleBar.Controls.Add(this.lb_titleChildForm);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(220, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(919, 80);
            this.panel_titleBar.TabIndex = 3;
            this.panel_titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titleBar_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimize.IconSize = 20;
            this.btn_minimize.Location = new System.Drawing.Point(836, 7);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(22, 20);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_maximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_maximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_maximize.IconSize = 20;
            this.btn_maximize.Location = new System.Drawing.Point(864, 7);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(22, 20);
            this.btn_maximize.TabIndex = 3;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_close.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_close.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 20;
            this.btn_close.Location = new System.Drawing.Point(892, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // icon_currentChildForm
            // 
            this.icon_currentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.icon_currentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.icon_currentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icon_currentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.icon_currentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_currentChildForm.Location = new System.Drawing.Point(26, 26);
            this.icon_currentChildForm.Name = "icon_currentChildForm";
            this.icon_currentChildForm.Size = new System.Drawing.Size(32, 32);
            this.icon_currentChildForm.TabIndex = 1;
            this.icon_currentChildForm.TabStop = false;
            // 
            // lb_titleChildForm
            // 
            this.lb_titleChildForm.AutoSize = true;
            this.lb_titleChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.lb_titleChildForm.Location = new System.Drawing.Point(70, 36);
            this.lb_titleChildForm.Name = "lb_titleChildForm";
            this.lb_titleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lb_titleChildForm.TabIndex = 0;
            this.lb_titleChildForm.Text = "Home";
            // 
            // panel_shadow
            // 
            this.panel_shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_shadow.Location = new System.Drawing.Point(220, 80);
            this.panel_shadow.Name = "panel_shadow";
            this.panel_shadow.Size = new System.Drawing.Size(919, 10);
            this.panel_shadow.TabIndex = 4;
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_desktop.Location = new System.Drawing.Point(220, 90);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(919, 553);
            this.panel_desktop.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 643);
            this.Controls.Add(this.panel_desktop);
            this.Controls.Add(this.panel_shadow);
            this.Controls.Add(this.panel_titleBar);
            this.Controls.Add(this.panel_menu);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_currentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private FontAwesome.Sharp.IconButton bt_home;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton bt_signOut;
        private FontAwesome.Sharp.IconButton bt_clipboard;
        private FontAwesome.Sharp.IconButton bt_student;
        private FontAwesome.Sharp.IconPictureBox pic_home;
        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.Label lb_titleChildForm;
        private FontAwesome.Sharp.IconPictureBox icon_currentChildForm;
        private System.Windows.Forms.Panel panel_shadow;
        private System.Windows.Forms.Panel panel_desktop;
        private FontAwesome.Sharp.IconPictureBox btn_minimize;
        private FontAwesome.Sharp.IconPictureBox btn_maximize;
        private FontAwesome.Sharp.IconPictureBox btn_close;
    }
}

