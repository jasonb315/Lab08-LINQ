using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using LinqLab.Classes;

namespace LinqLab
{
    //Create a program that brings in data from an external file, reads the data, and can filter the data based on specified values.

    //        Questions
    //-Each query builds off of the next.

    //Output all of the neighborhoods in this data list
    //Filter out all the neighborhoods that do not have any names
    //Remove the Duplicates
    //Rewrite the queries from above, and consolidate all into one single query.
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

            //Console.WriteLine(json);

            var Data = JsonConvert.DeserializeObject<FeatureCollection>(json);

            foreach (var item in Data.Features)
            {
                Console.WriteLine(item.Properties.city);
            }
        }
    }
}
