
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
            this.pl_inside = new System.Windows.Forms.Panel();
            this.pl_footer = new System.Windows.Forms.Panel();
            this.build = new System.Windows.Forms.Label();
            this.txt_creator = new System.Windows.Forms.Label();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.bt_maximize = new System.Windows.Forms.Button();
            this.pl_left = new System.Windows.Forms.Panel();
            this.bt_menu_collapse = new FontAwesome.Sharp.IconButton();
            this.pl_footer.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.pl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_inside
            // 
            this.pl_inside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.pl_inside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_inside.Location = new System.Drawing.Point(200, 33);
            this.pl_inside.Name = "pl_inside";
            this.pl_inside.Size = new System.Drawing.Size(1022, 974);
            this.pl_inside.TabIndex = 121;
            // 
            // pl_footer
            // 
            this.pl_footer.BackColor = System.Drawing.Color.Black;
            this.pl_footer.Controls.Add(this.build);
            this.pl_footer.Controls.Add(this.txt_creator);
            this.pl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_footer.Location = new System.Drawing.Point(0, 1007);
            this.pl_footer.Name = "pl_footer";
            this.pl_footer.Size = new System.Drawing.Size(1222, 24);
            this.pl_footer.TabIndex = 123;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.BackColor = System.Drawing.Color.Transparent;
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
            this.txt_creator.BackColor = System.Drawing.Color.Transparent;
            this.txt_creator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_creator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_creator.Location = new System.Drawing.Point(1060, 7);
            this.txt_creator.Name = "txt_creator";
            this.txt_creator.Size = new System.Drawing.Size(155, 13);
            this.txt_creator.TabIndex = 0;
            this.txt_creator.Text = "Developed by: André Comegno";
            this.txt_creator.Click += new System.EventHandler(this.txt_creator_Click);
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.Black;
            this.pl_top.Controls.Add(this.bt_exit);
            this.pl_top.Controls.Add(this.bt_minimize);
            this.pl_top.Controls.Add(this.bt_maximize);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1222, 33);
            this.pl_top.TabIndex = 124;
            this.pl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
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
            this.bt_exit.Location = new System.Drawing.Point(1190, 3);
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
            this.bt_minimize.Location = new System.Drawing.Point(1124, 3);
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
            this.bt_maximize.Location = new System.Drawing.Point(1157, 3);
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.Size = new System.Drawing.Size(27, 26);
            this.bt_maximize.TabIndex = 72;
            this.bt_maximize.Text = "❐";
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.pl_left.Controls.Add(this.bt_menu_collapse);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 33);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(200, 974);
            this.pl_left.TabIndex = 0;
            // 
            // bt_menu_collapse
            // 
            this.bt_menu_collapse.AccessibleName = "";
            this.bt_menu_collapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_menu_collapse.BackColor = System.Drawing.Color.Transparent;
            this.bt_menu_collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_menu_collapse.FlatAppearance.BorderSize = 0;
            this.bt_menu_collapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_menu_collapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_menu_collapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_menu_collapse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu_collapse.ForeColor = System.Drawing.Color.White;
            this.bt_menu_collapse.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.bt_menu_collapse.IconColor = System.Drawing.Color.White;
            this.bt_menu_collapse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_menu_collapse.IconSize = 35;
            this.bt_menu_collapse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_menu_collapse.Location = new System.Drawing.Point(12, 932);
            this.bt_menu_collapse.Name = "bt_menu_collapse";
            this.bt_menu_collapse.Size = new System.Drawing.Size(40, 36);
            this.bt_menu_collapse.TabIndex = 62;
            this.bt_menu_collapse.Tag = "";
            this.bt_menu_collapse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_menu_collapse.UseVisualStyleBackColor = false;
            this.bt_menu_collapse.Click += new System.EventHandler(this.bt_menu_collapse_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 1031);
            this.Controls.Add(this.pl_inside);
            this.Controls.Add(this.pl_left);
            this.Controls.Add(this.pl_top);
            this.Controls.Add(this.pl_footer);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio Concilig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pl_footer.ResumeLayout(false);
            this.pl_footer.PerformLayout();
            this.pl_top.ResumeLayout(false);
            this.pl_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pl_inside;
        private System.Windows.Forms.Panel pl_footer;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Label txt_creator;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_maximize;
        private System.Windows.Forms.Panel pl_left;
        private FontAwesome.Sharp.IconButton bt_menu_collapse;
    }
}

