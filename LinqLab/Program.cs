using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using LinqLab.Classes;
using System.Linq;

namespace LinqLab
{
    //Create a program that brings in data from an external file, reads the data, and can filter the data based on specified values.

    //        Questions
    //-Each query builds off of the next.
    //Rewrite at least one of these questions only using the opposing method(example:
    //Use LINQ Query statements instead of LINQ method calls and vice versa.)

    class Program
    {
        static void Main(string[] args)
        {
            DataParser();
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

            Feature[] f = bank.ToArray();

            var query = from i in f.Distinct()
                        where i.Properties.neighborhood.Length > 0
                        where i.Properties.address.Length > 0
                        orderby i.Properties.zip
                        select i;

            // consolidated query with filter
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

            Console.WriteLine("NEIGHBORHOODS");

            // alternate query
            var neighborhoods = Data.Features.Select(x => x)
                                               .Select(x => x.Properties.neighborhood)
                                               .Where(x => x != "")
                                               .Distinct();


            foreach (var item in neighborhoods)
            {
                Console.WriteLine(item);
            }

            //foreach (var item in bank)
            //{

            //    //Console.WriteLine(item.type);
            //    //Console.WriteLine(item.Properties.zip);
            //    //Console.WriteLine(item.Properties.city);
            //    //Console.WriteLine(item.Properties.state);
            //    //Console.WriteLine(item.Properties.address);
            //    //Console.WriteLine(item.Properties.borough);
            //    //Console.WriteLine(item.Properties.neighborhood);
            //    //Console.WriteLine(item.Properties.county);
            //    //Console.WriteLine();
            //}



        }
    }
}
