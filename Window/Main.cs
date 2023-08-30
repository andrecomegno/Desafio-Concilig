using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Desafio_Concilig
{
    public partial class main : Form
    {     

        public main()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();            

            try
            {
                new Login().ShowDialog();
            }
            finally
            {
                load_tables uc = new load_tables();
                addControll(uc);
            }            
        }

        public void addControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_inside.Controls.Clear();
            pl_inside.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // BOTÕES JANELA
        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void txt_creator_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/andrecomegno");

        //DROG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void main_Load(object sender, EventArgs e)
        {
            // MOSTRA O USERNAME DO LOGIN
            lb_user.Text = Login.Instance.username;

            // MOSTRA A DATA ATUAL
            lb_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


    }
}
