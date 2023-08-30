using System;
using System.Drawing;
using Desafio_Concilig.Script;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Desafio_Concilig
{
    public partial class Login : Form
    {
        public static Login Instance;
        public int id_user;
        public string username;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            Instance = this;
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            ButtonEnter();
        }

        // LOGICA DO BOTAO ENTRAR
        void ButtonEnter()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();

                // SELECT TABELA USER
                MySqlCommand objCmdLogin = new MySqlCommand("select id_user, name, password_hash from desafiorh.user where name=@name and password_hash=@password_hash ", database.getConnection());
                objCmdLogin.Parameters.AddWithValue("@name", txt_username.Texts);
                objCmdLogin.Parameters.AddWithValue("@password_hash", txt_password.Texts);

                // VERIFICA O USUARIO OU SENHA
                var login = objCmdLogin.ExecuteScalar();

                if (String.IsNullOrEmpty(txt_username.Texts))
                {
                    txt_username.BorderColor = Color.Red;
                    txt_username.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_password.Texts))
                {
                    txt_password.BorderColor = Color.Red;
                    txt_password.BorderSize = 3;
                }
                else
                {
                    if (login != null)
                    {
                        // COLETA O ID USER
                        MySqlDataReader dr = objCmdLogin.ExecuteReader();
                        while (dr.Read())
                        {
                            id_user = dr.GetInt32("id_user");
                            username = dr.GetString("name");
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User or Password not found !", "Failed !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTERNAL ERROR: " + ex, "INTERNAL ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txt_username.Texts = string.Empty;
                txt_password.Texts = string.Empty;
            }
        }

        // BOTAO MINIMIZAR E SAIR DO APP
        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        // LIMPAR AVISOS DO CAMPO TEXTO
        private void txt_username_Leave(object sender, EventArgs e)
        {
            txt_username.BorderColor = Color.Transparent;
            txt_username.BorderSize = 0;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            txt_password.BorderColor = Color.Transparent;
            txt_password.BorderSize = 0;
        }

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


    }
}
