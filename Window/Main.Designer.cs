
namespace Desafio_Concilig
{
    partial class main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_user_login = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.pl_inside = new System.Windows.Forms.Panel();
            this.pl_footer = new System.Windows.Forms.Panel();
            this.build = new System.Windows.Forms.Label();
            this.txt_creator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.bt_maximize = new System.Windows.Forms.Button();
            this.pl_top.SuspendLayout();
            this.pl_footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.Controls.Add(this.lb_user_login);
            this.pl_top.Controls.Add(this.lb_date);
            this.pl_top.Controls.Add(this.lb_user);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 33);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1125, 47);
            this.pl_top.TabIndex = 117;
            // 
            // lb_user_login
            // 
            this.lb_user_login.AutoSize = true;
            this.lb_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_login.ForeColor = System.Drawing.Color.Black;
            this.lb_user_login.Location = new System.Drawing.Point(135, 14);
            this.lb_user_login.Name = "lb_user_login";
            this.lb_user_login.Size = new System.Drawing.Size(64, 25);
            this.lb_user_login.TabIndex = 121;
            this.lb_user_login.Text = "User:";
            this.lb_user_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.ForeColor = System.Drawing.Color.Black;
            this.lb_date.Location = new System.Drawing.Point(12, 14);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(98, 25);
            this.lb_date.TabIndex = 120;
            this.lb_date.Text = "00/00/00";
            this.lb_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.Black;
            this.lb_user.Location = new System.Drawing.Point(195, 8);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(135, 31);
            this.lb_user.TabIndex = 119;
            this.lb_user.Text = "Unknown";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_inside
            // 
            this.pl_inside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_inside.Location = new System.Drawing.Point(0, 0);
            this.pl_inside.Name = "pl_inside";
            this.pl_inside.Size = new System.Drawing.Size(1125, 611);
            this.pl_inside.TabIndex = 121;
            // 
            // pl_footer
            // 
            this.pl_footer.BackColor = System.Drawing.Color.LightGray;
            this.pl_footer.Controls.Add(this.build);
            this.pl_footer.Controls.Add(this.txt_creator);
            this.pl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_footer.Location = new System.Drawing.Point(0, 587);
            this.pl_footer.Name = "pl_footer";
            this.pl_footer.Size = new System.Drawing.Size(1125, 24);
            this.pl_footer.TabIndex = 123;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.BackColor = System.Drawing.Color.LightGray;
            this.build.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.build.Location = new System.Drawing.Point(12, 6);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(31, 13);
            this.build.TabIndex = 1;
            this.build.Text = "v 1.0";
            // 
            // txt_creator
            // 
            this.txt_creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_creator.AutoSize = true;
            this.txt_creator.BackColor = System.Drawing.Color.LightGray;
            this.txt_creator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_creator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_creator.Location = new System.Drawing.Point(963, 7);
            this.txt_creator.Name = "txt_creator";
            this.txt_creator.Size = new System.Drawing.Size(155, 13);
            this.txt_creator.TabIndex = 0;
            this.txt_creator.Text = "Developed by: André Comegno";
            this.txt_creator.Click += new System.EventHandler(this.txt_creator_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_minimize);
            this.panel1.Controls.Add(this.bt_maximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 33);
            this.panel1.TabIndex = 124;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
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
            this.bt_exit.Location = new System.Drawing.Point(1093, 3);
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
            this.bt_minimize.Location = new System.Drawing.Point(1027, 3);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(27, 26);
            this.bt_minimize.TabIndex = 71;
            this.bt_minimize.Text = "🗕";
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_maximize
            // 
            this.bt_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximize.BackColor = System.Drawing.Color.Gray;
            this.bt_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_maximize.FlatAppearance.BorderSize = 0;
            this.bt_maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximize.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_maximize.ForeColor = System.Drawing.Color.White;
            this.bt_maximize.Location = new System.Drawing.Point(1060, 3);
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.Size = new System.Drawing.Size(27, 26);
            this.bt_maximize.TabIndex = 72;
            this.bt_maximize.Text = "❐";
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 611);
            this.Controls.Add(this.pl_top);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_footer);
            this.Controls.Add(this.pl_inside);
            this.MinimumSize = new System.Drawing.Size(698, 586);
            this.Name = "main";
            this.Text = "Desafio Concilig";
            this.Load += new System.EventHandler(this.main_Load);
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            this.pl_footer.ResumeLayout(false);
            this.pl_footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Panel pl_inside;
        private System.Windows.Forms.Panel pl_footer;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Label txt_creator;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_user_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_maximize;
    }
}

