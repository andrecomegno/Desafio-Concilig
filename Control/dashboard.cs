using System;
using CsvHelper;
using System.IO;
using System.Text;
using CsvHelper.Configuration;
using Desafio_Concilig.Script;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Data;

namespace Desafio_Concilig
{
    public partial class dashboard : UserControl
    {
        // IDS
        private int id_user = Login.Instance.id_user;
        private long id_import;
        // COLETARR DADOS
        private string username = Login.Instance.username;
        // GARVA A DATA ATUAL
        private string import_datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        // SELECIONAR UM USURIO NO COMBOBOX
        private string selectUser;
        // CHECKBOX
        private bool ckeckDelayInDay = false;

        public dashboard()
        {
            InitializeComponent();
        }

        #region TABLES
        void TableMain()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            string queryStandard = "select cl.client_name, cl.client_cpf, con.contract_number, pro.name_products, con.expiration_date, con.contract_amount, u.id_user, cl.id_client, con.id_contracts, pro.id_products, im.id_import from desafiorh.contracts_has_import has join desafiorh.contracts con on has.id_contracts = con.id_contracts join desafiorh.products pro on has.id_products = pro.id_products join desafiorh.client cl on has.id_client = cl.id_client join desafiorh.import im on has.id_import = im.id_import join desafiorh.user u on has.id_user = u.id_user where (@selectUser is NULL OR u.id_user = @selectUser) and cl.client_name like @searchname ";
            string queryCheck = "select cl.client_name, cl.client_cpf, con.contract_number, pro.name_products, con.expiration_date, SUM(con.contract_amount) AS contract_amount, MAX(DATEDIFF(CURDATE(), con.expiration_date)) AS Delay_In_Days, u.id_user, cl.id_client, con.id_contracts, pro.id_products, im.id_import from desafiorh.contracts_has_import has join desafiorh.contracts con on has.id_contracts = con.id_contracts join desafiorh.products pro on has.id_products = pro.id_products join desafiorh.client cl on has.id_client = cl.id_client join desafiorh.import im on has.id_import = im.id_import join desafiorh.user u on has.id_user = u.id_user GROUP BY cl.client_name "; 

            if (ckeckDelayInDay)
            {
                MySqlCommand cmd = new MySqlCommand(queryCheck, database.getConnection());

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(queryStandard, database.getConnection());
                // SELECIONA UM USUARIO NO COMBOBOX
                cmd.Parameters.AddWithValue("@selectUser", selectUser);
                // BUSCAR NOMES DENTRO DO DATAGRIDVIEW
                cmd.Parameters.AddWithValue("@searchName", "%" + txt_search.Texts);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            database.closeConnection();
        } 

        void TableLoadCSV(DateLoad records, int id)
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            //INSERT
            string insertClient = "INSERT INTO desafiorh.client (id_client, client_name, client_cpf) VALUES (null, @client_name, @client_cpf)";
            string insertProduct = "INSERT INTO desafiorh.products (id_products, name_products) VALUES (null, @name_products)";
            string insertContracts = "INSERT INTO desafiorh.contracts (id_contracts, contract_number, contract_amount, expiration_date, id_client, id_products) VALUES (null, @contract_number, @contract_amount, @expiration_date, @id_client, @id_products)";
            string insertHas = "INSERT INTO desafiorh.contracts_has_import (id_contracts, id_products, id_client, id_import, id_user ) VALUES (@id_contracts, @id_products, @id_client, @id_import, @id_user)";

            // CLIENTE 
            MySqlCommand cmdClient = new MySqlCommand(insertClient, database.getConnection());
            cmdClient.Parameters.Add("@client_name", MySqlDbType.VarChar, 145).Value = records.CLIENT_NAME;
            cmdClient.Parameters.Add("@client_cpf", MySqlDbType.VarChar, 14).Value = records.CLIENT_CPF;
            cmdClient.ExecuteNonQuery();
            long idClient = cmdClient.LastInsertedId;

            //  PRODUTO
            MySqlCommand cmdProducts = new MySqlCommand(insertProduct, database.getConnection());
            cmdProducts.Parameters.Add("@name_products", MySqlDbType.VarChar, 145).Value = records.NAME_PRODUCTS;
            cmdProducts.ExecuteNonQuery();
            long idProduct = cmdProducts.LastInsertedId;

            // VALOR DECIMAL DE UMS STRING FORMATADA  "R$ {0:N2}"
            string contractAmountString = records.CONTRACT_AMOUNT;
            // VALOR PADRÃO
            decimal NEW_CONTRACT_AMOUNT = 0;

            // REMOVER SIMBOLO E ESPAÇO EM BRANCO
            contractAmountString = contractAmountString.Replace("R$", "").Trim();

            // STRING PARA DECIMAL
            if (decimal.TryParse(contractAmountString, NumberStyles.Currency, new CultureInfo("pt-BR"), out NEW_CONTRACT_AMOUNT))
            {
                // CONTRACTS
                MySqlCommand cmdContracts = new MySqlCommand(insertContracts, database.getConnection());
                cmdContracts.Parameters.Add("@contract_number", MySqlDbType.Int32).Value = records.CONTRACT_NUMBER;
                cmdContracts.Parameters.Add("@contract_amount", MySqlDbType.Decimal).Value = NEW_CONTRACT_AMOUNT;
                cmdContracts.Parameters.Add("@expiration_date", MySqlDbType.Date).Value = records.EXPIRATION_DATE;
                cmdContracts.Parameters.Add("@id_client", MySqlDbType.Int32).Value = idClient;
                cmdContracts.Parameters.Add("@id_products", MySqlDbType.Int32).Value = idProduct;
                cmdContracts.ExecuteNonQuery();
                long idContracts = cmdContracts.LastInsertedId;

                // CONTRACTS HAS IMPORT
                MySqlCommand cmdHas = new MySqlCommand(insertHas, database.getConnection());
                cmdHas.Parameters.Add("@id_contracts", MySqlDbType.Int32).Value = idContracts;
                cmdHas.Parameters.Add("@id_products", MySqlDbType.Int32).Value = idProduct;
                cmdHas.Parameters.Add("@id_client", MySqlDbType.Int32).Value = idClient;
                cmdHas.Parameters.Add("@id_import", MySqlDbType.Int32).Value = id_import;
                cmdHas.Parameters.Add("@id_user", MySqlDbType.Int32).Value = id;
                cmdHas.ExecuteNonQuery();
            }

            database.closeConnection();
        }

        void TableUser(int id)
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            string cmd = "INSERT INTO desafiorh.import (id_import, import_datetime, id_user) VALUES (null, @import_datetime, @id_user)";

            // IMPORTAR
            MySqlCommand cmImport = new MySqlCommand(cmd, database.getConnection());
            cmImport.Parameters.Add("@import_datetime", MySqlDbType.DateTime).Value = import_datetime;
            cmImport.Parameters.Add("@id_user", MySqlDbType.Int32).Value = id;
            cmImport.ExecuteNonQuery();
            id_import = cmImport.LastInsertedId;

            database.closeConnection();
        }

        void TabelaComboBox()
        {
            configdb database = new configdb();
            database.openConnection();

            // MOSTRA TODOS OS CADASTROS DE CSV PELO USUARIO
            string query = "SELECT DISTINCT u.id_user FROM desafiorh.contracts_has_import has JOIN desafiorh.user u ON has.id_user = u.id_user ";

            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    // ATRIBUI TODOS OS USUARIO AO COMBOBOX
                    cb_search.Items.Add(dr.GetString(0));
                }
            }

            database.closeConnection();

            // INICIAR COM TODOS OS USUARIOS
            cb_search.SelectedIndex = 0;
        }

        #endregion

        #region BUTTONS
        // BOTÃO QUE CARREGAR CSV
        private void BT_LoadCSV()
        {
            // SELECIONAR SOMENTE AQUIVOS CSV
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    // GRAVA QUEM FEZ A IMPORTAÇÃO DO ARQUIVO CSV
                    TableUser(id_user);

                    // CABEÇALHO CSV
                    var records = new List<DateLoad>();

                    // DEFINA ACENTOS NOS ARQUIVOS CARREGADOS
                    Encoding encoding = Encoding.GetEncoding("ISO-8859-1");

                    using (var sr = new StreamReader(openFileDialog.FileName, encoding))
                    using (var csv = new CsvReader(sr, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        // DELIMITADOR
                        Delimiter = ";",
                    }))
                    {
                        // IGNORA LINHA DO CABEÇALHO
                        csv.Read();
                        csv.ReadHeader();

                        // MAPEAMENTO 
                        csv.Context.RegisterClassMap<DateMap>();

                        while (csv.Read())
                        {
                            var record = csv.GetRecord<DateLoad>();                            
                            
                            //CONVERTE O VALOR CONTRACT_AMOUNT PARA DECIMAL, QUANDO CARREGA UM NOVO CSV
                            if (decimal.TryParse(record.CONTRACT_AMOUNT, out decimal total))
                            {
                                // MOEDA BRASIL CONTRACT_AMOUNT
                                record.CONTRACT_AMOUNT = string.Format(new CultureInfo("pt-BR"), "R$ {0:N2}", total);
                            }

                            records.Add(record);
                            // SAVE AUTOMATICO
                            TableLoadCSV(record, id_user);
                        }
                    }

                    // CARREGA CSV
                    dataGridView1.DataSource = records;
                }
            }            
        }

        void BT_Logout()
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

        void BT_Setting()
        {
            // USERCONTROLE SETTING
        }

        private void bt_load_Click(object sender, EventArgs e) => BT_LoadCSV();

        private void bt_logout_Click(object sender, EventArgs e) => BT_Logout();

        private void bt_settings_Click(object sender, EventArgs e) => BT_Setting();
        #endregion

        #region Search
        private void cb_search_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cb_search.SelectedIndex)
                {
                    case 0:
                        // TODOS USUARIO
                        selectUser = null;
                        break;
                    default:
                        // SELECIONA USUARIO
                        selectUser = cb_search.SelectedItem.ToString();
                        break;
                }
            }
            finally
            {
                TableMain();
            }
        }

        private void txt_search__TextChanged(object sender, EventArgs e) => TableMain();

        #endregion

        private void load_tables_Load(object sender, EventArgs e)
        {
            // BEM-VINDO AO NOME DA CONTA LOGADA
            lb_username.Text = username + " !";

            TabelaComboBox();
            TableMain();
        }

        private void check_delay_in_days_CheckedChanged(object sender, EventArgs e)
        {
            // CKECKBOX TRUE OU FALSE
            ckeckDelayInDay = !ckeckDelayInDay;
            //ATUALIZA TABELA
            TableMain();
        }

    }
}
