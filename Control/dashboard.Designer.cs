
namespace Desafio_Concilig
{
    partial class dashboard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pl_inside = new System.Windows.Forms.Panel();
            this.pl_dashboard = new System.Windows.Forms.Panel();
            this.pl_search = new System.Windows.Forms.Panel();
            this.lb_search = new System.Windows.Forms.Label();
            this.txt_search = new Desafio_Concilig.Script.RJTextBox();
            this.cb_search = new Desafio_Concilig.Script.RJComboBox();
            this.pl_datagradview = new System.Windows.Forms.Panel();
            this.check_delay_in_days = new System.Windows.Forms.CheckBox();
            this.pl_profile = new System.Windows.Forms.Panel();
            this.bt_settings = new FontAwesome.Sharp.IconButton();
            this.im_profile = new Desafio_Concilig.Script.RJCircularPictureBox();
            this.bt_logout = new FontAwesome.Sharp.IconButton();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pl_top.SuspendLayout();
            this.pl_inside.SuspendLayout();
            this.pl_dashboard.SuspendLayout();
            this.pl_search.SuspendLayout();
            this.pl_datagradview.SuspendLayout();
            this.pl_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(28, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 441);
            this.dataGridView1.TabIndex = 126;
            // 
            // bt_load
            // 
            this.bt_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_load.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_load.FlatAppearance.BorderSize = 0;
            this.bt_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_load.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_load.ForeColor = System.Drawing.Color.White;
            this.bt_load.Location = new System.Drawing.Point(1002, 15);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(122, 36);
            this.bt_load.TabIndex = 125;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = false;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.pl_top.Controls.Add(this.lb_title);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1222, 77);
            this.pl_top.TabIndex = 147;
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(3, 23);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1216, 31);
            this.lb_title.TabIndex = 98;
            this.lb_title.Text = "DASHBOARD";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_inside
            // 
            this.pl_inside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.pl_inside.Controls.Add(this.pl_dashboard);
            this.pl_inside.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_inside.Location = new System.Drawing.Point(0, 77);
            this.pl_inside.Name = "pl_inside";
            this.pl_inside.Size = new System.Drawing.Size(1222, 954);
            this.pl_inside.TabIndex = 151;
            // 
            // pl_dashboard
            // 
            this.pl_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.pl_dashboard.Controls.Add(this.pl_search);
            this.pl_dashboard.Controls.Add(this.pl_datagradview);
            this.pl_dashboard.Controls.Add(this.pl_profile);
            this.pl_dashboard.Location = new System.Drawing.Point(18, 6);
            this.pl_dashboard.Name = "pl_dashboard";
            this.pl_dashboard.Size = new System.Drawing.Size(1182, 894);
            this.pl_dashboard.TabIndex = 0;
            // 
            // pl_search
            // 
            this.pl_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_search.Controls.Add(this.lb_search);
            this.pl_search.Controls.Add(this.txt_search);
            this.pl_search.Controls.Add(this.cb_search);
            this.pl_search.Location = new System.Drawing.Point(456, 26);
            this.pl_search.Name = "pl_search";
            this.pl_search.Size = new System.Drawing.Size(710, 189);
            this.pl_search.TabIndex = 126;
            // 
            // lb_search
            // 
            this.lb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search.ForeColor = System.Drawing.Color.White;
            this.lb_search.Location = new System.Drawing.Point(3, 11);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(704, 31);
            this.lb_search.TabIndex = 99;
            this.lb_search.Text = "Search";
            this.lb_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderColor = System.Drawing.Color.Transparent;
            this.txt_search.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_search.BorderRadius = 0;
            this.txt_search.BorderSize = 2;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.Location = new System.Drawing.Point(239, 92);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_search.PasswordChar = false;
            this.txt_search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_search.PlaceholderText = "Search Name";
            this.txt_search.Size = new System.Drawing.Size(447, 31);
            this.txt_search.TabIndex = 1;
            this.txt_search.Texts = "";
            this.txt_search.UnderlinedStyle = false;
            this.txt_search._TextChanged += new System.EventHandler(this.txt_search__TextChanged);
            // 
            // cb_search
            // 
            this.cb_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_search.BorderColor = System.Drawing.Color.Transparent;
            this.cb_search.BorderSize = 1;
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_search.ForeColor = System.Drawing.Color.DimGray;
            this.cb_search.IconColor = System.Drawing.Color.Black;
            this.cb_search.Items.AddRange(new object[] {
            "All User"});
            this.cb_search.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cb_search.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_search.Location = new System.Drawing.Point(32, 92);
            this.cb_search.MinimumSize = new System.Drawing.Size(200, 30);
            this.cb_search.Name = "cb_search";
            this.cb_search.Padding = new System.Windows.Forms.Padding(1);
            this.cb_search.Size = new System.Drawing.Size(200, 30);
            this.cb_search.TabIndex = 0;
            this.cb_search.Texts = "";
            this.cb_search.OnSelectedIndexChanged += new System.EventHandler(this.cb_search_OnSelectedIndexChanged);
            // 
            // pl_datagradview
            // 
            this.pl_datagradview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_datagradview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_datagradview.Controls.Add(this.check_delay_in_days);
            this.pl_datagradview.Controls.Add(this.bt_load);
            this.pl_datagradview.Controls.Add(this.dataGridView1);
            this.pl_datagradview.Location = new System.Drawing.Point(18, 221);
            this.pl_datagradview.Name = "pl_datagradview";
            this.pl_datagradview.Size = new System.Drawing.Size(1148, 554);
            this.pl_datagradview.TabIndex = 2;
            // 
            // check_delay_in_days
            // 
            this.check_delay_in_days.AutoSize = true;
            this.check_delay_in_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_delay_in_days.ForeColor = System.Drawing.Color.Tomato;
            this.check_delay_in_days.Location = new System.Drawing.Point(33, 22);
            this.check_delay_in_days.Name = "check_delay_in_days";
            this.check_delay_in_days.Size = new System.Drawing.Size(134, 24);
            this.check_delay_in_days.TabIndex = 127;
            this.check_delay_in_days.Text = "Delay in days";
            this.check_delay_in_days.UseVisualStyleBackColor = true;
            this.check_delay_in_days.CheckedChanged += new System.EventHandler(this.check_delay_in_days_CheckedChanged);
            // 
            // pl_profile
            // 
            this.pl_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_profile.Controls.Add(this.bt_settings);
            this.pl_profile.Controls.Add(this.im_profile);
            this.pl_profile.Controls.Add(this.bt_logout);
            this.pl_profile.Controls.Add(this.lb_welcome);
            this.pl_profile.Controls.Add(this.lb_username);
            this.pl_profile.Location = new System.Drawing.Point(18, 26);
            this.pl_profile.Name = "pl_profile";
            this.pl_profile.Size = new System.Drawing.Size(432, 189);
            this.pl_profile.TabIndex = 0;
            // 
            // bt_settings
            // 
            this.bt_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_settings.BackColor = System.Drawing.Color.Transparent;
            this.bt_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_settings.FlatAppearance.BorderSize = 0;
            this.bt_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_settings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_settings.ForeColor = System.Drawing.Color.White;
            this.bt_settings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.bt_settings.IconColor = System.Drawing.Color.White;
            this.bt_settings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_settings.IconSize = 35;
            this.bt_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_settings.Location = new System.Drawing.Point(379, 11);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Size = new System.Drawing.Size(41, 36);
            this.bt_settings.TabIndex = 128;
            this.bt_settings.Tag = "";
            this.bt_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_settings.UseVisualStyleBackColor = false;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // im_profile
            // 
            this.im_profile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.im_profile.BorderColor = System.Drawing.Color.RoyalBlue;
            this.im_profile.BorderColor2 = System.Drawing.Color.HotPink;
            this.im_profile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.im_profile.BorderSize = 2;
            this.im_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.im_profile.GradientAngle = 50F;
            this.im_profile.Image = global::Desafio_Concilig.Properties.Resources.user;
            this.im_profile.Location = new System.Drawing.Point(28, 40);
            this.im_profile.Name = "im_profile";
            this.im_profile.Size = new System.Drawing.Size(135, 135);
            this.im_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_profile.TabIndex = 0;
            this.im_profile.TabStop = false;
            // 
            // bt_logout
            // 
            this.bt_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logout.BackColor = System.Drawing.Color.Transparent;
            this.bt_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.ForeColor = System.Drawing.Color.White;
            this.bt_logout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.bt_logout.IconColor = System.Drawing.Color.White;
            this.bt_logout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_logout.IconSize = 35;
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.Location = new System.Drawing.Point(379, 144);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(41, 36);
            this.bt_logout.TabIndex = 127;
            this.bt_logout.Tag = "";
            this.bt_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.Color.White;
            this.lb_welcome.Location = new System.Drawing.Point(14, 11);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(134, 25);
            this.lb_welcome.TabIndex = 125;
            this.lb_welcome.Text = "Hi, Welcome";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.White;
            this.lb_username.Location = new System.Drawing.Point(178, 92);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(101, 25);
            this.lb_username.TabIndex = 123;
            this.lb_username.Text = "Unknown";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CLIENT_NAME";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CLIENT_CPF";
            this.Column2.HeaderText = "CPF";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CONTRACT_NUMBER";
            this.Column3.HeaderText = "Contrato";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NAME_PRODUCTS";
            this.Column4.HeaderText = "Produto";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EXPIRATION_DATE";
            this.Column5.HeaderText = "Vencimento";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CONTRACT_AMOUNT";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column6.HeaderText = "Valor";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DELAY_IN_DAYS";
            this.Column7.HeaderText = "Atraso em Dias";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID_USER";
            this.Column8.HeaderText = "id_user";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ID_CLIENT";
            this.Column9.HeaderText = "id_client";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ID_CONTRACTS";
            this.Column10.HeaderText = "id_contracts";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ID_PRODUCTS";
            this.Column11.HeaderText = "id_products";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "ID_IMPORT";
            this.Column12.HeaderText = "id_import";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_inside);
            this.Controls.Add(this.pl_top);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1222, 1031);
            this.Load += new System.EventHandler(this.load_tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pl_top.ResumeLayout(false);
            this.pl_inside.ResumeLayout(false);
            this.pl_dashboard.ResumeLayout(false);
            this.pl_search.ResumeLayout(false);
            this.pl_datagradview.ResumeLayout(false);
            this.pl_datagradview.PerformLayout();
            this.pl_profile.ResumeLayout(false);
            this.pl_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Panel pl_inside;
        private System.Windows.Forms.Panel pl_dashboard;
        private System.Windows.Forms.Panel pl_datagradview;
        private System.Windows.Forms.Panel pl_profile;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Panel pl_search;
        private FontAwesome.Sharp.IconButton bt_logout;
        private Script.RJCircularPictureBox im_profile;
        private System.Windows.Forms.Label lb_title;
        private Script.RJTextBox txt_search;
        private Script.RJComboBox cb_search;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.CheckBox check_delay_in_days;
        private FontAwesome.Sharp.IconButton bt_settings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}
