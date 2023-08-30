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

namespace Desafio_Concilig
{
    public partial class load_tables : UserControl
    {
        private int id_user = Login.Instance.id_user;
        private int id_products;
        private string username;
        private string client_name;
        private string client_cpf;
        private string name_products;
        private int contract_number;
        private decimal contract_amount;
        private DateTime expiration_date;

        public load_tables()
        {            
            InitializeComponent();
        }

        void TableCSV(int id)
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            //INSERT
            string insertClient = "INSERT INTO desafiorh.client (id_client, client_name, client_cpf) VALUES (null, @client_name, @client_cpf)";
            string insertProduct = "INSERT INTO desafiorh.products (id_products, name_products) VALUES (null, @name_products)";
            string insertContracts = "INSERT INTO desafiorh.contracts (id_contracts, contract_number, contract_amount, expiration_date, id_client, id_products) VALUES (null, @contract_number, @contract_amount, @expiration_date, @id_client, @id_products)";
            string insertImport = "INSERT INTO desafiorh.import (id_import, import_datetime, id_user) VALUES (null, @import_datetime, @id_user)";

            // CLIENTE
            MySqlCommand cmdClient = new MySqlCommand(insertClient, database.getConnection());
            cmdClient.Parameters.Add("@client_name", MySqlDbType.VarChar, 145).Value = client_name;
            cmdClient.Parameters.Add("@client_cpf", MySqlDbType.VarChar, 11).Value = client_cpf;
            cmdClient.ExecuteNonQuery();
            long idUsername = cmdClient.LastInsertedId;

            //  PRODUCT
            MySqlCommand cmdProducts = new MySqlCommand(insertProduct, database.getConnection());
            cmdProducts.Parameters.Add("@name_products", MySqlDbType.VarChar, 145).Value = name_products;
            cmdProducts.ExecuteNonQuery();
            long idProduct = cmdProducts.LastInsertedId;

            // CONTRACTS
            MySqlCommand cmContracts = new MySqlCommand(insertContracts, database.getConnection());
            cmContracts.Parameters.Add("@contract_number", MySqlDbType.Int32).Value = contract_number;
            cmContracts.Parameters.Add("@contract_amount", MySqlDbType.Decimal).Value = contract_amount;
            cmContracts.Parameters.Add("@expiration_date", MySqlDbType.Date).Value = expiration_date;
            cmContracts.Parameters.Add("@id_client", MySqlDbType.Int32).Value = idUsername;
            cmContracts.Parameters.Add("@id_products", MySqlDbType.Int32).Value = idProduct;
            cmContracts.ExecuteNonQuery();

            // IMPORTAR
            MySqlCommand cmImport = new MySqlCommand(insertImport, database.getConnection());
            cmImport.Parameters.Add("@import_datetime", MySqlDbType.Date).Value = contract_number;
            cmImport.Parameters.Add("@id_user", MySqlDbType.Int32).Value = id;
            cmImport.ExecuteNonQuery();

            database.closeConnection();
        }

        void BT_Save(int iduser)
        {
            try
            {
                // VERIFICAR SE JA EXISTE O CPF CADASTRADO ANTES DE SALVAR

                /*
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();
                
                string checkIfExistsQuery = "SELECT COUNT(*) FROM desafiorh.contracts WHERE contract_number = @contract_number";
                MySqlCommand cmdCheckIfExists = new MySqlCommand(checkIfExistsQuery, database.getConnection());
                cmdCheckIfExists.Parameters.Add("@id_products", MySqlDbType.Int32).Value = contract_number;
                int recordCount = Convert.ToInt32(cmdCheckIfExists.ExecuteScalar());

                if (dataGridView1.Rows.Count > 1)
                {
                    if (recordCount > 0)
                    {
                        // TABELA UPDATE
                        TableEditPayDay();
                    }
                    else
                    {
                        // TABELA INSERT
                        TableCSV(iduser);
                    }
                }

                database.closeConnection();
                */

                TableCSV(iduser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Cast Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÃO AUTO SALVA CSV
        void AutoSaveCSV(object sender, DataGridViewCellEventArgs e, int iduser)
        {
            // IMPLEMENTACAO DO AUTOSAVE EM TESTE
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridViews = (DataGridView)sender;
                DataGridViewRow row = dataGridViews.Rows[e.RowIndex];

                // CABEÇALHO DENTRO DO DATAGRIDVIEW  *** TEMPORARIO
                client_name = row.Cells[0].Value == DBNull.Value ? "N/A" : row.Cells[0].Value.ToString();
                client_cpf = row.Cells[1].Value == DBNull.Value ? "N/A" : row.Cells[1].Value.ToString();
                contract_number = row.Cells[2].Value == DBNull.Value ? 0 : (int)row.Cells[2].Value;
                name_products = row.Cells[3].Value == DBNull.Value ? "N/A" : row.Cells[3].Value.ToString();
                expiration_date = row.Cells[4].Value == DBNull.Value ? DateTime.Now : (DateTime)row.Cells[1].Value;
                client_name = row.Cells[0].Value == DBNull.Value ? "N/A" : row.Cells[0].Value.ToString();

                // VALOR TOTAL DA COMPRA
                string contractAmount = row.Cells[5].Value.ToString();
                if (decimal.TryParse(contractAmount, out decimal totalamount))
                {
                    contract_amount = totalamount;
                }
                else
                {
                    contract_amount = 0;
                }

                // BOTÃO SALVAR
                BT_Save(iduser);
            }
        }

        // BOTÃO CARREGAR CSV
        private void BT_LoadCSV()
        {
            // SELECIONAR SOMENTE AQUIVOS CSV
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
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

                            //CONVERTE O VALOR CONTRACT_AMOUNT PARA DECIMAL
                            if (decimal.TryParse(record.CONTRACT_AMOUNT, out decimal valor))
                            {
                                // MOEDA BRASIL CONTRACT_AMOUNT
                                record.CONTRACT_AMOUNT = string.Format(new CultureInfo("pt-BR"), "R$ {0:N2}", valor);
                            }

                            records.Add(record);
                        }
                    }

                    // CARREGA CSV
                    dataGridView1.DataSource = records;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) => AutoSaveCSV(sender, e, id_user);
        private void bt_load_Click(object sender, EventArgs e) => BT_LoadCSV();

    }
}
