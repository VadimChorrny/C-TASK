using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;

namespace Exchange_Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeOffice office = new ExchangeOffice()
            {
                ccy = "RUR",
                base_ccy = "UAH",
                buy = "0.2800",
                sell = "0.32000"
            };

            string path = @"Kurs.json";

            string jsonStr = JsonSerializer.Serialize<ExchangeOffice>(office);
            File.WriteAllText(path, jsonStr);
            Console.WriteLine("----MY EXCHANGE JSON----");
            Console.WriteLine(jsonStr);

            //var result = JsonSerializer.Deserialize<List<ExchangeOffice>>(jsonStr);
            //result = result.Where(ex => ex.sell == "0.32000" && ex.buy == "0.2800").ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Web-Client");
            //WebClient wc = new WebClient();
            //string json = wc.DownloadString("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
            //Console.WriteLine(jsonStr);
            // add list

        }
    }
}
