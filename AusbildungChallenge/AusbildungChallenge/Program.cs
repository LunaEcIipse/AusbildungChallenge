using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace AusbildungChallenge
{
    internal class Program
    {

        static void Main(string[] args)
        {

            ReadCSV();

        }
        public static void ReadCSV()
        {
            //Gives the Code ";" as a seperation symbol instead of ","
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "\";\"",
                HasHeaderRecord = false,
                Mode = CsvMode.NoEscape
            };
            //Reads file and turns it into a readable list for the code, but I cant figure out how to solve the MissingFielFound Error
            using (var streamReader = new StreamReader(@"E:\GitHubDesktop\AusbildungChallenge\AusbildungChallenge\AusbildungChallenge\Artikel.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, config))
                {

                    var records = csvReader.GetRecords<Article>().ToList();

                }
            }
        }
        //Declares the Headers for the values in the table
        public class Article
        {
            [Name("Hauptartikelnr")]
            public string Hauptartikelnummer { get; set; }
            [Name("Artikelname")]
            public string Artikelname { get; set; }
            [Name("Hersteller")]
            public string Hersteller { get; set; }
            [Name("Beschreibung")]
            public string Beschreibung { get; set; }
            [Name("Materialangaben")]
            public string Materialangaben { get; set; }
            [Name("Geschlecht")]
            public string Geschlecht { get; set; }
            [Name("Produktart")]
            public string Produktart { get; set; }
            [Name("Ärmel")]
            public string Ärmel { get; set; }
            [Name("Bein")]
            public string Bein { get; set; }
            [Name("Kragen")]
            public string Kragen { get; set; }
            [Name("Herstellung")]
            public string Herstellung { get; set; }
            [Name("Grammatur")]
            public string Grammatur { get; set; }
            [Name("Material")]
            public string Material { get; set; }
            [Name("Ursprungsland")]
            public string Ursprungsland { get; set; }
            [Name("Bildname")]
            public string Bildname { get; set; }


        }
    }
}
