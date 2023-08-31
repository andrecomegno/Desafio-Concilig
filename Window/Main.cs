using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Desafio_Concilig
{
    public partial class main : Form
    {

        // MENU RECOLHER
        bool _menuCollapse;

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
                dashboard uc = new dashboard();
                addControl(uc);
            }            
        }

        // CARREGA O USER CONTROL DESEJADO DENTRO DO MAIN
        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_inside.Controls.Clear();
            pl_inside.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #region BUTTON TOP
        // BOTÕES MENU TOPO JANELA
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
        #endregion

        #region MENU LATERAL
        // MENU LATERAL 
        private void MenuCollapse(bool _collapse)
        {
            // RECOLHE O MENU E ADAPTA OS BOTÕES
            if (_collapse)
            {
                pl_left.Width = 60;
                bt_menu_collapse.IconChar = IconChar.AngleRight;

                foreach (Button menuButton in pl_left.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
            else
            {
                pl_left.Width = 200;
                bt_menu_collapse.IconChar = IconChar.AngleLeft;

                foreach (Button menuButton in pl_left.Controls.OfType<Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void bt_menu_collapse_Click(object sender, EventArgs e) => Menu_Collapse();
        private void Menu_Collapse() => MenuCollapse(_menuCollapse = !_menuCollapse);
        #endregion

        //ARRASTAR FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // CREDITOS
        private void txt_creator_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/andrecomegno");

    }
}
