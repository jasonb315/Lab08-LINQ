using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using LinqLab.Classes;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataParser();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exiting Program");
            }
        }

        static void DataParser()
        {
            string path = "../../../../data.json";
            var json = "";

            using (StreamReader sr = File.OpenText(path))
            {
                json = sr.ReadToEnd();
            }

            var Data = JsonConvert.DeserializeObject<FeatureCollection>(json);


            List<Feature> bank = new ArrayList<Feature>();
            foreach (var item in Data.Features)
            {
                bank.Add(item);
            }

            var query = from i in bank.Distinct()
                        where i.Properties.neighborhood.Length > 0
                        where i.Properties.address.Length > 0
                        orderby i.Properties.zip
                        select i;

            int itemNumber = 0;
            foreach (var item in query)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"ITEM: {itemNumber}:");
                //Console.WriteLine(item.type);
                //Console.WriteLine(item.Properties.zip);
                //Console.WriteLine(item.Properties.city);
                //Console.WriteLine(item.Properties.state);
                Console.WriteLine(item.Properties.address);
                Console.WriteLine(item.Properties.borough);
                Console.WriteLine(item.Properties.neighborhood);
                //Console.WriteLine(item.Properties.county);
                Console.WriteLine("----------------------");
                itemNumber++;
            }

            Console.WriteLine("NEIGHBORHOOD LIST");

            // alternate query
            var neighborhoods = Data.Features.Select(x => x)
                                             .Select(x => x.Properties.neighborhood)
                                             .Where(x => x != "")
                                             .Distinct();

            foreach (var item in neighborhoods)
            {
                Console.WriteLine(item);
            }
        }
    }
}
