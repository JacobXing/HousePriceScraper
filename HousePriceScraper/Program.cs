﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using CsvHelper;


namespace HousePriceScraper
{
    public class Program
    {
        static void Main(string[] args)
        {
            // --csv=filepath

            Regex csv = new Regex(@"^\-\-csv=");

            var argCsvPath = args.FirstOrDefault(arg => csv.IsMatch(arg));

            var pathCsv = csv.Replace(argCsvPath, "");

            Spider spider = new Spider();

            int lineNumber = 0;
            string lineNumberPath = $"{AppContext.BaseDirectory}/line.txt";

            if (File.Exists(lineNumberPath))
            {
                lineNumber = int.Parse(File.ReadAllText(lineNumberPath));

                Console.WriteLine($"Resumed from {lineNumber}");
            }

            int index = 0;

            using (StreamReader csvStreamReader = new StreamReader(pathCsv))
            {
                using (CsvReader csvReader = new CsvReader(csvStreamReader))
                {
                    csvReader.Configuration.BadDataFound = null;
                    // csvReader.Read();

                    while (csvReader.Read())
                    {
                        if (index < lineNumber)
                        {
                            var row = csvReader.GetRecord<dynamic>();
                            var dict = row as IDictionary<string, object>;
                        }
                        else
                        {
                            var row = csvReader.GetRecord<dynamic>();
                            var dict = row as IDictionary<string, object>;

                            var prop = new Property();

                            prop.UnitNumber = dict["UNIT NUMBER"] as string;
                            prop.HouseNumber = dict["HOUSE NUMBER"] as string;
                            prop.StreetName = dict["STREET NAME"] as string;
                            prop.StreetType = dict["STREET TYPE"] as string;
                            prop.StreetSuffix = dict["STREET SUFFIX"] as string;
                            prop.Suburb = dict["SUBURB"] as string;
                            prop.Postcode = dict["POSTCODE"] as string;
                            prop.AddressUseType = dict["ADDRESS USE TYPE"] as string;
                            prop.WardName = dict["WARD NAME"] as string;
                            prop.PropertyDescription = dict["PROPERTY DESCRIPTION"] as string;

                            prop.BuildKey();

                            spider.Search(prop);

                            File.WriteAllText(lineNumberPath, index.ToString());
                        }
                        index += 1;

                    }
                }


            }

        }
    }
}
