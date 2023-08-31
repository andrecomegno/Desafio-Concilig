
namespace Desafio_Concilig
{
    partial class Login
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
            this.bt_enter = new System.Windows.Forms.Button();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.build = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.txt_username = new Desafio_Concilig.Script.RJTextBox();
            this.txt_password = new Desafio_Concilig.Script.RJTextBox();
            this.pl_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_enter
            // 
            this.bt_enter.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_enter.FlatAppearance.BorderSize = 0;
            this.bt_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter.ForeColor = System.Drawing.Color.White;
            this.bt_enter.Location = new System.Drawing.Point(59, 215);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(184, 58);
            this.bt_enter.TabIndex = 79;
            this.bt_enter.Text = "ENTER";
            this.bt_enter.UseVisualStyleBackColor = false;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.Color.Black;
            this.pl_menu.Controls.Add(this.bt_exit);
            this.pl_menu.Controls.Add(this.bt_minimize);
            this.pl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu.Location = new System.Drawing.Point(0, 0);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(300, 38);
            this.pl_menu.TabIndex = 80;
            this.pl_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.BackColor = System.Drawing.Color.Gray;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Location = new System.Drawing.Point(266, 5);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(27, 26);
            this.bt_exit.TabIndex = 70;
            this.bt_exit.Text = "X";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimize.BackColor = System.Drawing.Color.Gray;
            this.bt_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimize.FlatAppearance.BorderSize = 0;
            this.bt_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Location = new System.Drawing.Point(233, 5);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(27, 26);
            this.bt_minimize.TabIndex = 71;
            this.bt_minimize.Text = "🗕";
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.build);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 30);
            this.panel2.TabIndex = 81;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.build.Location = new System.Drawing.Point(262, 8);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(31, 13);
            this.build.TabIndex = 1;
            this.build.Text = "v 1.1";
            // 
            // lb_login
            // 
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(0, 50);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(300, 50);
            this.lb_login.TabIndex = 84;
            this.lb_login.Text = "LOGIN";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.BorderColor = System.Drawing.Color.White;
            this.txt_username.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_username.BorderRadius = 0;
            this.txt_username.BorderSize = 1;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.Location = new System.Drawing.Point(26, 138);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_username.PasswordChar = true;
            this.txt_username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_username.PlaceholderText = "Name";
            this.txt_username.Size = new System.Drawing.Size(250, 31);
            this.txt_username.TabIndex = 85;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = false;
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderColor = System.Drawing.Color.White;
            this.txt_password.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_password.BorderRadius = 0;
            this.txt_password.BorderSize = 1;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Location = new System.Drawing.Point(26, 177);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_password.PasswordChar = true;
            this.txt_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(250, 31);
            this.txt_password.TabIndex = 86;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = false;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(300, 397);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pl_menu);
            this.Controls.Add(this.bt_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.pl_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.Panel pl_menu;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Label lb_login;
        private Script.RJTextBox txt_username;
        private Script.RJTextBox txt_password;
    }
}