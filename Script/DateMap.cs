using CsvHelper.Configuration;

namespace Desafio_Concilig.Script
{
    public class DateMap : ClassMap<DateLoad>
    {

        // FOI CRIADO UMA DATA MAPA PARA MELHOR ENTENDIMENTO, E ATRIBUIR O CABEÇALHO
        public DateMap()
        {
            Map(v => v.CLIENT_NAME).Name("Nome");
            Map(v => v.CLIENT_CPF).Name("CPF");
            Map(v => v.CONTRACT_NUMBER).Name("Contrato");
            Map(v => v.NAME_PRODUCTS).Name("Produto");
            // CONVERSAO DA DATA PARA PADRAO BRASIL
            Map(m => m.EXPIRATION_DATE).Name("Vencimento").TypeConverter<ConvertDateCSV>();
            Map(v => v.CONTRACT_AMOUNT).Name("Valor");
        }
    }
}
