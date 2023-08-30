using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;


namespace Desafio_Concilig.Script
{
    class ConvertDateCSV : DateTimeConverter
    {
        // CONVERSAO DA DATA PARA O PADRÃO BRASIL
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (DateTime.TryParseExact(text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                return result;
            }
            return base.ConvertFromString(text, row, memberMapData);
        }
    }
}
