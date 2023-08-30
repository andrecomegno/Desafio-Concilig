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
        private string import_datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public load_tables()
        {
            InitializeComponent();
        }

        void TableCSV(DateLoad records)
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
            cmdClient.Parameters.Add("@client_name", MySqlDbType.VarChar, 145).Value = records.CLIENT_NAME;
            cmdClient.Parameters.Add("@client_cpf", MySqlDbType.VarChar, 14).Value = records.CLIENT_CPF;
            cmdClient.ExecuteNonQuery();
            long idUsername = cmdClient.LastInsertedId;

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

            // Tentar converter a string formatada para decimal
            if (decimal.TryParse(contractAmountString, NumberStyles.Currency, new CultureInfo("pt-BR"), out NEW_CONTRACT_AMOUNT))
            {
                // A conversão foi bem-sucedida, agora você pode usar 'contractAmount' em seu comando SQL
                // CONTRACTS
                MySqlCommand cmContracts = new MySqlCommand(insertContracts, database.getConnection());
                cmContracts.Parameters.Add("@contract_number", MySqlDbType.Int32).Value = records.CONTRACT_NUMBER;
                cmContracts.Parameters.Add("@contract_amount", MySqlDbType.Decimal).Value = NEW_CONTRACT_AMOUNT;
                cmContracts.Parameters.Add("@expiration_date", MySqlDbType.Date).Value = records.EXPIRATION_DATE;
                cmContracts.Parameters.Add("@id_client", MySqlDbType.Int32).Value = idUsername;
                cmContracts.Parameters.Add("@id_products", MySqlDbType.Int32).Value = idProduct;
                cmContracts.ExecuteNonQuery();
            }

            /*
            // IMPORTAR
            MySqlCommand cmImport = new MySqlCommand(insertImport, database.getConnection());
            cmImport.Parameters.Add("@import_datetime", MySqlDbType.DateTime).Value = import_datetime;
            cmImport.Parameters.Add("@id_user", MySqlDbType.Int32).Value = id;
            cmImport.ExecuteNonQuery();
            */

            database.closeConnection();
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
                            // SAVE AUTOMATICO
                            TableCSV(record);
                        }
                    }

                    // CARREGA CSV
                    dataGridView1.DataSource = records;
                }
            }
        }

        private void bt_load_Click(object sender, EventArgs e) => BT_LoadCSV();
    }
}
